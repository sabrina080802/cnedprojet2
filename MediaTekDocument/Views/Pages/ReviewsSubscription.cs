using MediaTekDocument.Data.DAL;
using MediaTekDocument.Data.Model;
using System.Data;
using System.Reflection;

namespace MediaTekDocument.Views.Pages
{
    /// <summary>
    /// UserControl contenant la gestion des abonnements aux revues
    /// </summary>
    public partial class ReviewsSubscription : UserControl
    {
        /// <summary>
        /// Etat actuel du tri 
        /// </summary>
        private string currentSort;
        /// <summary>
        /// Abonnement en cours d'édition (sélectionnée dans le dgvSubscribeList)
        /// </summary>
        private Command editingSubscription;
        /// <summary>
        /// Revue en cours d'édition (celle recherchée dans le formulaire)
        /// </summary>
        private Review editingReview;
        /// <summary>
        /// Défini si l'utilisateur est en train de modifier les informations de l'abonnement sélectionné
        /// </summary>
        private bool isEditable = false;

        public ReviewsSubscription()
        {
            InitializeComponent();
            dgvSubscribeList.DataSource = new List<Command>();
            dgvSubscribeList.Columns["IdSuivi"].HeaderText = "Etat de la commande";
            dgvSubscribeList.Columns["IdSuivi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// Suppression d'une commande avec confirmation
        /// </summary>
        private async void btnDeleteCommand_Click(object sender, EventArgs e)
        {
            if (editingSubscription == null) return;

            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet abonnement ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            await DALManager.Delete<Command>(editingSubscription);
            UpdateReviewFields();
        }

        /// <summary>
        /// Switch le mode d'édition (lecture ou écriture)
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEditable = !isEditable;
            UpdateEditFields(true);
        }

        /// <summary>
        /// Configure les controls selon le mode d'édition (lecture ou écriture)
        /// Si l'on passe en mode lecture et que la valeur de save est à true, on sauvegarde les informations fournies par l'utilisateur
        /// </summary>
        private void UpdateEditFields(bool save = false)
        {
            if (isEditable)
            {
                btnEdit.FlatAppearance.BorderColor = Color.YellowGreen;
                btnEdit.BackColor = Color.YellowGreen;

                btnEdit.Text = "Sauvegarder";
                btnDeleteCommand.Visible = true;
                dtpSubscriptionEndDate.Enabled = true;
            }
            else
            {
                btnEdit.FlatAppearance.BorderColor = Color.DodgerBlue;
                btnEdit.BackColor = Color.DodgerBlue;
                btnEdit.Text = "Modifier les informations";
                btnDeleteCommand.Visible = false;
                dtpSubscriptionEndDate.Enabled = false;

                if (!save) return;
                if (dtpSubscriptionEndDate.Value < DateTime.Now)
                {
                    //Erreur dans le cas où l'utilisateur indique une date antérieure à maintenant
                    MessageBox.Show("Vous ne pouvez pas définir une date antérieure", "Erreur");
                    return;
                }

                //On fait de l'asynchrone ici mais nous ne sommes pas obligé de l'attendre
                DALManager.Update<Subscription>(editingSubscription.Id, new Dictionary<string, string>()
                {
                    {"dateFinAbonnement", dtpSubscriptionEndDate.Value.ToString("yyyy-M-d") }
                });
            }
        }

        /// <summary>
        /// Création d'une commande lorsque l'on clique sur le bouton Nouvelle Commande
        /// </summary>
        private async void btnNewCommand_Click(object sender, EventArgs e)
        {
            SubscribeSelectEndDateForm endDateSelector = new SubscribeSelectEndDateForm();
            endDateSelector.ShowDialog();
            if (endDateSelector.Result == null) return;


            editingSubscription = await DALManager.Post<Command>(new Dictionary<string, string>()
            {
                {"IdRevue", editingReview.Id },
                {"DateFinAbonnement", endDateSelector.Result?.ToString("yyyy-M-d") }
            });
            UpdateReviewFields();
        }

        /// <summary>
        /// Déclenche la recherche selon ce que l'utilisateur a indiqué dans le champs numéro de revue
        /// Si aucune revue n'est trouvée, on lui indique un message d'erreur
        /// </summary>
        private async void btnSearchReview_Click(object sender, EventArgs e)
        {
            editingReview = await DALManager.Get<Review>(tbReviewId.Text);
            isEditable = false;

            UpdateReviewFields();
            if (editingReview == null)
                MessageBox.Show("Aucun revue trouvée à ce numéro", "Revue introuvable");
        }

        /// <summary>
        /// Met à jour les control selon les informations de la revue recherchée par l'utilisateur
        /// </summary>
        private async void UpdateReviewFields()
        {
            if (editingReview != null)
            {
                tbTitle.Text = editingReview.Titre;
                tbDelay.Text = editingReview.DelaiMiseADispo.ToString();
                tbPeriodicity.Text = editingReview.Periodicite;
                tbGender.Text = BaseDataManager.GetNameOf<Gender>(editingReview.IdGenre);
                tbPublic.Text = BaseDataManager.GetNameOf<Public>(editingReview.IdPublic);
                tbDepartment.Text = BaseDataManager.GetNameOf<Department>(editingReview.IdRayon);
                tbImagePath.Text = editingReview.Image;
                btnDeleteCommand.Enabled = true;
                btnEdit.Enabled = true;
                btnNewCommand.Enabled = true;

                dgvSubscribeList.DataSource = await DALManager.GetAll<Command>(new Dictionary<string, string>()
                {
                    {"idRevue", editingReview.Id }
                });
            }
            else
            {
                tbTitle.Text = string.Empty;
                tbDelay.Text = string.Empty;
                tbPeriodicity.Text = string.Empty;
                tbGender.Text = string.Empty;
                tbPublic.Text = string.Empty;
                tbDepartment.Text = string.Empty;
                tbImagePath.Text = string.Empty;
                dgvSubscribeList.DataSource = new List<Command>();
                btnDeleteCommand.Enabled = false;
                btnEdit.Enabled = false;
                btnNewCommand.Enabled = false;
                dgvSubscribeList.DataSource = new List<Command>();
            }

            dgvSubscribeList.Columns["IdSuivi"].HeaderText = "Etat de la commande";
            dgvSubscribeList.Columns["IdSuivi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// Lorsque l'utilisateur choisit un abonnement dans la liste qui lui est proposée, on redéfinit le mode d'édition à lecture
        /// et on met à jour les control
        /// </summary>
        private void DgvCommandList_SelectionChanged(object sender, EventArgs e)
        {
            editingSubscription = (Command)((dgvSubscribeList.SelectedRows.Count > 0) ? dgvSubscribeList.SelectedRows[0].DataBoundItem : null);
            isEditable = false;
            UpdateCommandField();
            UpdateEditFields();
        }

        /// <summary>
        /// Met à jour le contenu des control en fonction des informations de l'abonnement sélectionné
        /// </summary>
        private async void UpdateCommandField()
        {
            if (editingSubscription != null)
            {
                dtpCommandDate.Value = editingSubscription.DateCommande;
                tbCommandId.Text = editingSubscription.Id;
                nudCommandCost.Value = (decimal)editingSubscription.Montant;
                Subscription subscription = await DALManager.Get<Subscription>(editingSubscription.Id);
                dtpSubscriptionEndDate.Value = subscription.DateFinAbonnement;
            }
            else
            {
                tbCommandId.Text = string.Empty;
            }
        }

        /// <summary>
        /// Permet de gérer l'affichage de l'état de la commande pour ne pas afficher un id mais bien le nom de l'état
        /// </summary>
        private void DgvCommandList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex != dgvSubscribeList.Columns["IdSuivi"].Index || e.Value == null) return;

            Command command = dgvSubscribeList.Rows[e.RowIndex].DataBoundItem as Command;
            e.Value = BaseDataManager.GetNameOf<CommandState>(command.IdSuivi.ToString());
        }

        /// <summary>
        /// Gestion générique du tri de chacune des colonnes des abonnements
        /// </summary>
        private void DgvCommandList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = dgvSubscribeList.Columns[e.ColumnIndex];
            string direction;

            List<Command> dataList = (List<Command>)dgvSubscribeList.DataSource;
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
            dgvSubscribeList.DataSource = dataList;
            dgvSubscribeList.Columns["IdSuivi"].HeaderText = "Etat de la commande";
            dgvSubscribeList.Columns["IdSuivi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
