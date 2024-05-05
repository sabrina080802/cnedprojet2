using MediaTekDocument.Data.DAL;
using MediaTekDocument.Data.Model;

namespace MediaTekDocument.Views.Pages
{
    /// <summary>
    /// UserControl de gestion de la liste des livres
    /// </summary>
    public partial class Books : UserControl
    {
        /// <summary>
        /// Livre sélectionné par l'utilisateur pour son édition / consultation
        /// </summary>
        private Book editingBook;
        /// <summary>
        /// Mode d'édition (lecture / écriture)
        /// </summary>
        private bool isEditing = false;

        public Books()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Charge la liste des livres dans le SearchArea et affecte en DataSource la liste des rayons, genres et publics
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
        /// Met à jour les control selon ce que l'utilisateur a sélectionné dans la liste des livres
        /// </summary>
        private void RefreshEditMode()
        {
            cbDepartment.Enabled = isEditing;
            cbPublic.Enabled = isEditing;
            cbGender.Enabled = isEditing;
            tbISBN.ReadOnly = !isEditing;
            tbTitle.ReadOnly = !isEditing;
            tbAuthor.ReadOnly = !isEditing;
            tbImagePath.ReadOnly = !isEditing;
            tbCollection.ReadOnly = !isEditing;
            if (editingBook != null)
            {
                tbNumber.Text = editingBook.Id;
                tbTitle.Text = editingBook.Titre;
                tbAuthor.Text = editingBook.Auteur;
                tbCollection.Text = editingBook.Collection;
                tbISBN.Text = editingBook.ISBN;
                tbImagePath.Text = editingBook.Image;
                cbDepartment.SelectedIndex = BaseDataManager.Departments.FindIndex(x => editingBook.IdRayon.Equals(x.Id));
                cbGender.SelectedIndex = BaseDataManager.Genders.FindIndex(x => editingBook.IdGenre.Equals(x.Id));
                cbPublic.SelectedIndex = BaseDataManager.Publics.FindIndex(x => editingBook.IdPublic.Equals(x.Id));
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
        /// Sauvegarde les informations d'un livre suite à la modification par l'utilisateur
        /// </summary>
        private async void SaveBook()
        {
            editingBook.Titre = tbTitle.Text;
            editingBook.Collection = tbCollection.Text;
            editingBook.Auteur = tbAuthor.Text;
            editingBook.Image = tbImagePath.Text;
            editingBook.ISBN = tbISBN.Text;
            editingBook.IdGenre = (cbGender.SelectedItem as Gender).Id;
            editingBook.IdRayon = (cbDepartment.SelectedItem as Department).Id;
            editingBook.IdPublic = (cbPublic.SelectedItem as Public).Id;

            await DALManager.Update(editingBook);
            dataList.Refresh();
        }

        /// <summary>
        /// Répond à l'événement du SearchArea lorsque l'utilisateur choisit une revue dans la liste
        /// </summary>
        private void dataList_DataSelectionChanged(Book data)
        {
            editingBook = data;
            if (data == null) return;

            isEditing = false;
            RefreshEditMode();
        }

        /// <summary>
        /// Lorsque l'on clique sur Nouveau livre, on créé une nouveau livre
        /// Si l'utilisateur a sélectionné un genre, un public ou un rayon, on utilisera sa sélection comme valeur par défaut
        /// </summary>
        private async void btnNewBook_Click(object sender, EventArgs e)
        {
            Book newBook = await DALManager.Post(new Book()
            {
                Titre = "Sans nom",
                Auteur = "Inconnu",
                Collection = String.Empty,
                Image = String.Empty,
                ISBN = String.Empty,
                IdGenre = (cbGender.SelectedIndex > 0 ? cbGender.SelectedItem as Gender : cbGender.Items[1] as Gender).Id,
                IdPublic = (cbPublic.SelectedIndex > 0 ? cbPublic.SelectedItem as Public : cbPublic.Items[1] as Public).Id,
                IdRayon = (cbDepartment.SelectedIndex > 0 ? cbDepartment.SelectedItem as Department : cbPublic.Items[1] as Department).Id
            });

            await dataList.SearchData();
            dataList.Select(newBook);
            isEditing = true;
            RefreshEditMode();
        }

        /// <summary>
        /// Demande la validation de suppression d'un livre et supprime si l'utilisateur l'accepte
        /// </summary>
        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (editingBook == null) return;

            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce livre ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            await DALManager.Delete(editingBook);
            await dataList.SearchData();
        }

        /// <summary>
        /// Switch le mode d'édition entre écriture ou lecture
        /// </summary>
        private void btnEdit_MouseClick(object sender, MouseEventArgs e)
        {
            if (isEditing)
                SaveBook();

            isEditing = !isEditing;
            RefreshEditMode();
        }
    }
}
