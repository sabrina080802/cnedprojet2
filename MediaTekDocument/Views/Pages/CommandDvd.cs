using MediaTekDocument.Data.DAL;
using MediaTekDocument.Data.Model;
using System.Data;
using System.Reflection;

namespace MediaTekDocument.Views.Pages
{
    /// <summary>
    /// UserControl permettant de gérer la liste des commandes d'un DVD
    /// </summary>
    public partial class CommandDvd : UserControl
    {
        /// <summary>
        /// Etat actuel du tri
        /// </summary>
        private string currentSort;
        /// <summary>
        /// DVD en cours de consultation
        /// </summary>
        private Dvd editingDvd;
        /// <summary>
        /// Commande sélectionnée par l'utilisateur
        /// </summary>
        private Command editingCommand;
        /// <summary>
        /// Mode d'édition de la commande (lecture / écriture)
        /// </summary>
        private bool isEditable = false;

        public CommandDvd()
        {
            InitializeComponent();
            dgvCommandList.DataSource = new List<Command>();
            dgvCommandList.Columns["IdSuivi"].HeaderText = "Etat de la commande";
            dgvCommandList.Columns["IdSuivi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// Lorsque l'utilisateur choisit une commande dans la liste, on met à jour les champs et on réinitialise le mode d'édition
        /// </summary>
        private void DgvCommandList_SelectionChanged(object sender, EventArgs e)
        {
            editingCommand = (Command)((dgvCommandList.SelectedRows.Count > 0) ? dgvCommandList.SelectedRows[0].DataBoundItem : null);
            isEditable = false;
            UpdateCommandField();
            UpdateEditFields();
        }

        /// <summary>
        /// Met à jour les informations selon la commande sélectionnée par l'utilisateur
        /// </summary>
        private async void UpdateCommandField()
        {
            if (editingCommand != null)
            {
                dtpCommandDate.Value = editingCommand.DateCommande;
                tbCommandId.Text = editingCommand.Id;
                nudCommandCost.Value = (decimal)editingCommand.Montant;
                cbCommandStatus.SelectedItem = BaseDataManager.CommandStates.First(x => byte.Parse(x.Id) == editingCommand.IdSuivi);
                dgvCommandDocumentList.DataSource = await DALManager.GetAll<CommandDocument>(new Dictionary<string, string>(){
                    {"id", editingCommand.Id }
                });
            }
            else
            {
                tbCommandId.Text = string.Empty;
                cbCommandStatus.SelectedText = string.Empty;
                dgvCommandDocumentList.DataSource = new List<CommandDocument>();
            }

            dgvCommandDocumentList.Columns["Id"].Visible = false;
            dgvCommandDocumentList.Columns["IdLivreDvd"].Visible = false;
            dgvCommandDocumentList.Columns["Titre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCommandDocumentList.Columns["Titre"].DisplayIndex = 0;
            dgvCommandDocumentList.Columns["Titre"].ReadOnly = true;
            dgvCommandDocumentList.Columns["NbExemplaire"].DisplayIndex = 1;
            dgvCommandDocumentList.Columns["NbExemplaire"].ReadOnly = true;
        }

        /// <summary>
        /// Supprime une commande après validation par l'utilisateur
        /// </summary>
        private async void btnDeleteCommand_Click(object sender, EventArgs e)
        {
            if (editingCommand == null) return;

            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette commande ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            await DALManager.Delete<Command>(editingCommand);
            UpdateDvdFields();
        }

        /// <summary>
        /// Création d'une nouvelle commande lorsque l'on clique sur Nouvelle Commande
        /// </summary>
        private async void btnNewCommand_Click(object sender, EventArgs e)
        {
            editingCommand = await DALManager.Post<Command>(new Dictionary<string, string>()
            {
                {"IdLivreDvd", editingDvd.Id }
            });
            UpdateDvdFields();
        }

        /// <summary>
        /// Déclenche la recherche selon ce que l'utilisateur a indiqué dans le champs numéro de DVD
        /// </summary>
        private async void btnSearchDvd_Click(object sender, EventArgs e)
        {
            cbCommandStatus.DataSource = BaseDataManager.CommandStates;
            cbCommandStatus.DisplayMember = "Libelle";
            editingDvd = await DALManager.Get<Dvd>(tbDvdId.Text);
            isEditable = false;

            UpdateDvdFields();
            if (editingDvd == null)
                MessageBox.Show("Aucun livre trouvé à ce numéro", "Livre introuvable");
        }

        /// <summary>
        /// Switch le mode lecture ou écriture
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEditable = !isEditable;
            UpdateEditFields(true);
        }

        /// <summary>
        /// Met à jour les control selon le mode d'édition et les informations de la commande sélectionnée par l'utilisateur
        /// Si l'on passe en mode lecture et que save vaut true, on déclenche la mise à jour des données par celles saisies par l'utilisateur
        /// </summary>
        private void UpdateEditFields(bool save = false)
        {
            if (isEditable)
            {
                btnEdit.FlatAppearance.BorderColor = Color.YellowGreen;
                btnEdit.BackColor = Color.YellowGreen;

                btnEdit.Text = "Sauvegarder";
                btnAddDocument.Visible = editingCommand.IdSuivi < 2;
                btnDeleteCommand.Visible = true;
                cbCommandStatus.Enabled = true;
                dgvCommandDocumentList.Columns["NbExemplaire"].ReadOnly = false;
            }
            else
            {
                btnEdit.FlatAppearance.BorderColor = Color.DodgerBlue;
                btnEdit.BackColor = Color.DodgerBlue;
                btnEdit.Text = "Modifier les informations";
                btnDeleteCommand.Visible = false;
                cbCommandStatus.Enabled = false;
                btnAddDocument.Visible = false;

                if (dgvCommandDocumentList.Columns.Contains("NbExemplaire"))
                    dgvCommandDocumentList.Columns["NbExemplaire"].ReadOnly = true;

                if (!save) return;
                editingCommand.IdSuivi = byte.Parse((cbCommandStatus.SelectedItem as CommandState).Id);
                //On met à jour les informations de la commande (changement d'état)
                DALManager.Update<Command>(editingCommand);

                List<CommandDocument> list = dgvCommandDocumentList.DataSource as List<CommandDocument>;
                Dictionary<string, string> newCopyCountPerDocument = new Dictionary<string, string>();
                list.ForEach(x => newCopyCountPerDocument.Add(x.IdLivreDvd, x.NbExemplaire.ToString()));

                //On met à jour les informations de chaque commandDocument (nombre d'exemplaires)
                DALManager.Update<CommandDocument>(editingCommand.Id, newCopyCountPerDocument);

                dgvCommandList.Refresh();
            }
        }

        /// <summary>
        /// Met à jour les control selon le résultat de la recherche de l'utilisateur
        /// </summary>
        private async void UpdateDvdFields()
        {
            if (editingDvd != null)
            {
                tbTitle.Text = editingDvd.Titre;
                tbSynopsis.Text = editingDvd.Synopsis;
                tbReal.Text = editingDvd.Realisateur;
                tbDuration.Text = editingDvd.Duree.ToString();
                tbGender.Text = BaseDataManager.GetNameOf<Gender>(editingDvd.IdGenre);
                tbPublic.Text = BaseDataManager.GetNameOf<Public>(editingDvd.IdPublic);
                tbDepartment.Text = BaseDataManager.GetNameOf<Department>(editingDvd.IdRayon);
                tbImagePath.Text = editingDvd.Image;

                //On charge la liste des commandes du DVD sélectionné
                dgvCommandList.DataSource = await DALManager.GetAll<Command>(new Dictionary<string, string>()
                {
                    {"idLivreDvd", editingDvd.Id}
                });
                btnDeleteCommand.Enabled = true;
                btnEdit.Enabled = true;
                btnNewCommand.Enabled = true;
            }
            else //Pas de DVD trouvé
            {
                dtpCommandDate.Text = string.Empty;
                tbSynopsis.Text = string.Empty;
                tbTitle.Text = string.Empty;
                tbReal.Text = string.Empty;
                tbDuration.Text = string.Empty;
                tbGender.Text = string.Empty;
                tbPublic.Text = string.Empty;
                tbDepartment.Text = string.Empty;
                tbImagePath.Text = string.Empty;
                dgvCommandList.DataSource = new List<Command>();
                btnDeleteCommand.Enabled = false;
                btnEdit.Enabled = false;
                btnNewCommand.Enabled = false;
            }

            dgvCommandList.Columns["IdSuivi"].HeaderText = "Etat de la commande";
            dgvCommandList.Columns["IdSuivi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// Lorsque l'utilisateur clique sur Ajouter un DVD, on ouvre la fenêtre de sélection de document
        /// Si l'utilisateur a sélectionné un document dans la fenêtre, on créer un nouveau CommandDocument et on l'ajoute au
        /// DataSource localement
        /// </summary>
        private async void btnAddDocument_Click(object sender, EventArgs e)
        {
            DocumentSearchForm docSearchForm = new DocumentSearchForm();
            docSearchForm.ShowDialog();
            if (docSearchForm.Result != null)
            {
                await DALManager.Post<CommandDocument>(new Dictionary<string, string>()
                {
                    {"idLivreDvd", docSearchForm.Result.IdLivreDvd },
                    {"nbExemplaire", docSearchForm.Result.NbExemplaire.ToString() },
                    {"id", editingCommand.Id }
                });

                List<CommandDocument> cmdDocs = (dgvCommandDocumentList.DataSource as List<CommandDocument>);
                cmdDocs.Add(docSearchForm.Result);
                dgvCommandDocumentList.DataSource = new List<CommandDocument>();
                dgvCommandDocumentList.DataSource = cmdDocs;
            }
        }


        /// <summary>
        /// Permet de reformatter le contenu des cellules pour la colonne IdSuivi afin de remplacer le chiffre par le texte
        /// </summary>
        private void DgvCommandList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex != dgvCommandList.Columns["IdSuivi"].Index || e.Value == null) return;

            Command command = dgvCommandList.Rows[e.RowIndex].DataBoundItem as Command;
            e.Value = BaseDataManager.GetNameOf<CommandState>(command.IdSuivi.ToString());
        }

        /// <summary>
        /// Gestion générique du tri pour toutes les colonnes
        /// </summary>
        private void DgvCommandList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = dgvCommandList.Columns[e.ColumnIndex];
            string direction;

            List<Command> dataList = (List<Command>)dgvCommandList.DataSource;
            PropertyInfo sortedProperty = typeof(Command).GetProperty(column.DataPropertyName);
            if (currentSort == column.DataPropertyName + " ASC")
            {
                direction = "DESC";
                dataList = dataList.OrderBy(x => sortedProperty.GetValue(x)).Reverse().ToList();
            }
            else
            {
                direction = "ASC";
                dataList = dataList.OrderBy(x => sortedProperty.GetValue(x)).ToList();
            }

            currentSort = $"{column.DataPropertyName} {direction}";
            dgvCommandList.DataSource = dataList;
            dgvCommandList.Columns["IdSuivi"].HeaderText = "Etat de la commande";
            dgvCommandList.Columns["IdSuivi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// Si l'utilisateur tente de sélectionner un état inférieur pour la commande, on lui affiche un message d'erreur
        /// </summary>
        private void cbCommandStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (editingCommand == null) return;

            if (cbCommandStatus.SelectedIndex < editingCommand.IdSuivi)
            {
                MessageBox.Show("Vous ne pouvez pas passer un document dans un état précédent auquel il se trouve actuellement", "Erreur");
                cbCommandStatus.SelectedIndex = editingCommand.IdSuivi;
            }
        }
    }
}
