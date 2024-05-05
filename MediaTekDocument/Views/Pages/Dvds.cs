using MediaTekDocument.Data.DAL;
using MediaTekDocument.Data.Model;

namespace MediaTekDocument.Views.Pages
{
    /// <summary>
    /// UserControl qui permet de gérer la liste des DVD
    /// </summary>
    public partial class Dvds : UserControl
    {
        /// <summary>
        /// DVD sélectionné par l'utilisateur
        /// </summary>
        private Dvd editingDvd;
        /// <summary>
        /// Mode d'édition (lecture / écriture)
        /// </summary>
        private bool isEditing = false;

        public Dvds()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Charge la liste des DVD dans le SearchArea et affecte en DataSource la liste des rayons, genres et publics
        /// dont le chargement est centralisé dans BaseDataManager
        /// </summary>
        public async void LoadData()
        {
            await dataList.LoadData();
            cbDepartment.DataSource = BaseDataManager.Departments;
            cbPublic.DataSource = BaseDataManager.Publics;
            cbGender.DataSource = BaseDataManager.Genders;
        }

        /// <summary>
        /// Met à jour les control selon ce que l'utilisateur a sélectionné dans la liste des DVD
        /// </summary>
        private void RefreshEditMode()
        {
            cbDepartment.Enabled = isEditing;
            cbPublic.Enabled = isEditing;
            cbGender.Enabled = isEditing;
            tbDuration.ReadOnly = !isEditing;
            tbTitle.ReadOnly = !isEditing;
            tbReal.ReadOnly = !isEditing;
            tbImagePath.ReadOnly = !isEditing;
            tbSynopsis.ReadOnly = !isEditing;
            if (editingDvd != null)
            {
                tbNumber.Text = editingDvd.Id;
                tbTitle.Text = editingDvd.Titre;
                tbReal.Text = editingDvd.Realisateur;
                tbSynopsis.Text = editingDvd.Synopsis;
                tbDuration.Text = editingDvd.Duree.ToString();
                tbImagePath.Text = editingDvd.Image;
                cbDepartment.SelectedIndex = BaseDataManager.Departments.FindIndex(x => editingDvd.IdRayon.Equals(x.Id));
                cbGender.SelectedIndex = BaseDataManager.Genders.FindIndex(x => editingDvd.IdGenre.Equals(x.Id));
                cbPublic.SelectedIndex = BaseDataManager.Publics.FindIndex(x => editingDvd.IdPublic.Equals(x.Id));
            }

            if (isEditing)
            {
                btnEdit.Text = "Sauvegarder";
                btnEdit.BackColor = Color.LimeGreen;
            }
            else
            {
                btnEdit.Text = "Modifier les informations";
                btnEdit.BackColor = Color.DodgerBlue;
            }

        }


        /// <summary>
        /// Sauvegarde les informations d'un DVD suite à la modification par l'utilisateur
        /// </summary>
        private async void SaveDvd()
        {
            if (!int.TryParse(tbDuration.Text, out int duration))
            {
                MessageBox.Show("La durée entrée n'est pas un nombre", "Une erreur est survenue");
                return;
            }

            editingDvd.Titre = tbTitle.Text;
            editingDvd.Synopsis = tbSynopsis.Text;
            editingDvd.Realisateur = tbReal.Text;
            editingDvd.Image = tbImagePath.Text;
            editingDvd.Duree = duration;
            editingDvd.IdGenre = (cbGender.SelectedItem as Gender).Id;
            editingDvd.IdRayon = (cbDepartment.SelectedItem as Department).Id;
            editingDvd.IdPublic = (cbPublic.SelectedItem as Public).Id;

            await DALManager.Update(editingDvd);
            dataList.Refresh();
        }

        /// <summary>
        /// Répond à l'événement du SearchArea lorsque l'utilisateur choisit un DVD dans la liste
        /// </summary>
        private void dataList_DataSelectionChanged(Dvd data)
        {
            editingDvd = data;
            if (data == null) return;

            isEditing = false;
            RefreshEditMode();
        }

        /// <summary>
        /// Lorsque l'on clique sur Nouveau DVD, on créé un nouveau DVD
        /// Si l'utilisateur a sélectionné un genre, un public ou un rayon, on utilisera sa sélection comme valeur par défaut
        /// </summary>
        private async void btnNewDvd_Click(object sender, EventArgs e)
        {
            Dvd newDvd = await DALManager.Post(new Dvd()
            {
                Titre = "Sans nom",
                Realisateur = "Inconnu",
                Synopsis = String.Empty,
                Image = String.Empty,
                Duree = 0,
                IdGenre = (cbGender.SelectedIndex > 0 ? cbGender.SelectedItem as Gender : cbGender.Items[1] as Gender).Id,
                IdPublic = (cbPublic.SelectedIndex > 0 ? cbPublic.SelectedItem as Public : cbPublic.Items[1] as Public).Id,
                IdRayon = (cbDepartment.SelectedIndex > 0 ? cbDepartment.SelectedItem as Department : cbPublic.Items[1] as Department).Id
            });

            await dataList.SearchData();
            dataList.Select(newDvd);
            isEditing = true;
            RefreshEditMode();
        }

        /// <summary>
        /// Demande la validation de suppression d'une revue et supprime si l'utilisateur l'accepte
        /// </summary>
        private async void btnDeleteDvd_Click(object sender, EventArgs e)
        {
            if (editingDvd == null) return;

            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce DVD ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            await DALManager.Delete(editingDvd);
            await dataList.SearchData();
        }

        /// <summary>
        /// Switch le mode d'édition entre écriture ou lecture
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isEditing)
                SaveDvd();

            isEditing = !isEditing;
            RefreshEditMode();
        }
    }
}
