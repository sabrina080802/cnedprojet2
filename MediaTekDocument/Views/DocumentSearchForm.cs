using MediaTekDocument.Data.DAL;
using MediaTekDocument.Data.Model;

namespace MediaTekDocument.Views
{
    /// <summary>
    /// Form qui permet à l'utilisateur de sélectionner un document dans une ComboBox parmis ceux disponibles
    /// </summary>
    public partial class DocumentSearchForm : Form
    {
        public CommandDocument Result;

        public DocumentSearchForm()
        {
            InitializeComponent();
            cbDocumentList.DisplayMember = "titre";
            LoadData();
        }

        /// <summary>
        /// Déclenche le chargement asynchrone des données des livres, dvd
        /// Le résultat est mergé dans une List de Document qui est utilisée comme DataSource sur la comboBox cbDocumentList
        /// </summary>
        private async void LoadData()
        {
            List<Document> documents = new List<Document>();
            List<Book> bookList = await DALManager.GetAll<Book>();
            List<Dvd> dvdList = await DALManager.GetAll<Dvd>();
            documents.AddRange(bookList);
            documents.AddRange(dvdList);

            cbDocumentList.DataSource = documents;
        }

        /// <summary>
        /// Quand on clique sur Valider, on récupère ce que l'utilisateur a sélectionné dans la liste de documents
        /// Puis on ferme la fenêtre
        /// </summary>
        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (cbDocumentList.SelectedIndex != -1 && nudCopyCount.Value > 0)
            {
                Document document = (cbDocumentList.SelectedItem as Document);
                Result = new CommandDocument()
                {
                    Titre = document.Titre,
                    IdLivreDvd = document.Id,
                    NbExemplaire = (int)(nudCopyCount.Value)
                };
            }
            else Result = null;

            Close();
        }

        /// <summary>
        /// Quand on clique sur annuler, on remet s'assure que le résultat est à null puis on ferme la fenêtre
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Result = null;
            Close();
        }
    }
}
