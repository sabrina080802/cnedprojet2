using MediaTekDocument.Data.DAL;
using MediaTekDocument.Data.Model;

namespace MediaTekDocument.Views.Pages
{
    /// <summary>
    /// UserControl de gestion de la liste des revues
    /// </summary>
    public partial class Reviews : UserControl
    {
        /// <summary>
        /// Revue sélectionnée par l'utilisateur pour son édition / consultation
        /// </summary>
        private Review editingReview;
        /// <summary>
        /// Mode d'édition (lecture / écriture)
        /// </summary>
        private bool isEditing = false;

        public Reviews()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Charge la liste des revues dans le SearchArea et affecte en DataSource la liste des rayons, genres et publics
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
        /// Met à jour les control selon ce que l'utilisateur a sélectionné dans la liste des revues
        /// </summary>
        private void RefreshEditMode()
        {
            cbDepartment.Enabled = isEditing;
            cbPublic.Enabled = isEditing;
            cbGender.Enabled = isEditing;
            tbPeriodicity.ReadOnly = !isEditing;
            tbTitle.ReadOnly = !isEditing;
            tbDelay.ReadOnly = !isEditing;
            tbImagePath.ReadOnly = !isEditing;
            if (editingReview != null)
            {
                tbNumber.Text = editingReview.Id;
                tbTitle.Text = editingReview.Titre;
                tbPeriodicity.Text = editingReview.Periodicite;
                tbDelay.Text = editingReview.DelaiMiseADispo.ToString();
                tbImagePath.Text = editingReview.Image;
                cbDepartment.SelectedIndex = BaseDataManager.Departments.FindIndex(x => editingReview.IdRayon.Equals(x.Id));
                cbGender.SelectedIndex = BaseDataManager.Genders.FindIndex(x => editingReview.IdGenre.Equals(x.Id));
                cbPublic.SelectedIndex = BaseDataManager.Publics.FindIndex(x => editingReview.IdPublic.Equals(x.Id));
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
        /// Sauvegarde les informations d'une revue suite à la modification par l'utilisateur
        /// </summary>
        private async void SaveReview()
        {
            if (!int.TryParse(tbDelay.Text, out int delay))
            {
                MessageBox.Show("La durée entrée n'est pas un nombre", "Une erreur est survenue");
                return;
            }

            editingReview.Titre = tbTitle.Text;
            editingReview.Periodicite = tbPeriodicity.Text;
            editingReview.Image = tbImagePath.Text;
            editingReview.DelaiMiseADispo = delay;
            editingReview.IdGenre = (cbGender.SelectedItem as Gender).Id;
            editingReview.IdRayon = (cbDepartment.SelectedItem as Department).Id;
            editingReview.IdPublic = (cbPublic.SelectedItem as Public).Id;

            await DALManager.Update(editingReview);
            dataList.Refresh();
        }


        /// <summary>
        /// Répond à l'événement du SearchArea lorsque l'utilisateur choisit une revue dans la liste
        /// </summary>
        private void dataList_DataSelectionChanged(Review data)
        {
            editingReview = data;
            if (data == null) return;

            isEditing = false;
            RefreshEditMode();
        }

        /// <summary>
        /// Lorsque l'on clique sur Nouvelle Revue, on créé une nouvelle revue
        /// Si l'utilisateur a sélectionné un genre, un public ou un rayon, on utilisera sa sélection comme valeur par défaut
        /// </summary>
        private async void btnNewReview_Click(object sender, EventArgs e)
        {
            Review newReview = await DALManager.Post(new Review()
            {
                Titre = "Sans nom",
                Periodicite = "",
                Image = String.Empty,
                DelaiMiseADispo = 0,
                IdGenre = (cbGender.SelectedIndex > 0 ? cbGender.SelectedItem as Gender : cbGender.Items[1] as Gender).Id,
                IdPublic = (cbPublic.SelectedIndex > 0 ? cbPublic.SelectedItem as Public : cbPublic.Items[1] as Public).Id,
                IdRayon = (cbDepartment.SelectedIndex > 0 ? cbDepartment.SelectedItem as Department : cbPublic.Items[1] as Department).Id
            });

            await dataList.SearchData();
            dataList.Select(newReview);
            isEditing = true;
            RefreshEditMode();
        }

        /// <summary>
        /// Demande la validation de suppression d'une revue et supprime si l'utilisateur l'accepte
        /// </summary>
        private async void btnDeleteReview_Click(object sender, EventArgs e)
        {
            if (editingReview == null) return;

            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette revue ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            await DALManager.Delete(editingReview);
            await dataList.SearchData();
        }

        /// <summary>
        /// Switch le mode d'édition entre écriture ou lecture
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isEditing)
                SaveReview();

            isEditing = !isEditing;
            RefreshEditMode();
        }
    }
}
