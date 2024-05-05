using MediaTekDocument.Data.DAL;
using MediaTekDocument.Data.Model;
using System.Reflection;

namespace MediaTekDocument.Views.Components
{

    /// <summary>
    /// UserControl générique permettant de gérer une recherche par numéro, titre, genre, rayon et public
    /// </summary>
    /// <typeparam name="T">Le type de données, doit étendre la classe Document</typeparam>
    public partial class SearchArea<T> : UserControl
        where T : Document
    {
        /// <summary>
        /// Delegate qui sert à l'événement DataSelectionChanged et qui fournit en paramètre une donnée
        /// </summary>
        public delegate void DataDelegateEvent(T data);
        /// <summary>
        /// Evénement déclenché lorsque l'utilisateur sélectionne une donnée dans le DataGridView
        /// </summary>
        public event DataDelegateEvent DataSelectionChanged;
        /// <summary>
        /// Liste des colonnes affichées dans le DataGridView
        /// </summary>
        protected List<string> DisplayedColumns = new List<string>() { "id", "titre", "idGenre", "idRayon", "idPublic" };
        /// <summary>
        /// Etat actuel du tri
        /// </summary>
        private string currentSort = String.Empty;
        /// <summary>
        /// Etat indiquant si l'interface est en cours de chargement
        /// </summary>
        private bool isLoading = false;

        public SearchArea()
        {
            InitializeComponent();
            dgvData.DataSource = new List<T>();
            UpdateColumnConfig();
        }

        /// <summary>
        /// Permet de sélectionner par programmation une donnée précise dans le DataGridView
        /// </summary>
        public void Select(T data)
        {
            foreach (DataGridViewRow row in dgvData.Rows)
                row.Selected = ((row.DataBoundItem as T).Id == data.Id);

            if (dgvData.SelectedRows.Count > 0)
                dgvData.FirstDisplayedScrollingRowIndex = dgvData.SelectedRows[0].Index;
        }

        /// <summary>
        /// Déclenche un chargement asynchrone des données et associe les genre, rayons et publiques aux comboBox associés
        /// </summary>
        /// <returns></returns>
        public async Task LoadData()
        {
            await BaseDataManager.Load();
            cbGender.DataSource = new List<Gender>(BaseDataManager.Genders);
            cbDepartment.DataSource = new List<Department>(BaseDataManager.Departments);
            cbPublic.DataSource = new List<Public>(BaseDataManager.Publics);

            await SearchData();
        }

        /// <summary>
        /// Recherche une donnée selon les entrées de l'utilisateur en construisant une requête dont les paramètres sont optionnels
        /// </summary>
        public async Task SearchData()
        {
            if (isLoading) return;
            isLoading = true;
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            if (cbGender.SelectedIndex > 0)
            {
                Gender gender = cbGender.SelectedItem as Gender;
                parameters.Add("idGenre", gender.Id);
            }
            if (cbDepartment.SelectedIndex > 0)
            {
                Department department = cbDepartment.SelectedItem as Department;
                parameters.Add("idRayon", department.Id);
            }
            if (cbPublic.SelectedIndex > 0)
            {
                Public @public = cbPublic.SelectedItem as Public;
                parameters.Add("idPublic", @public.Id);
            }

            if (!String.IsNullOrEmpty(tbSearchNumber.Text))
                parameters.Add("id", tbSearchNumber.Text);

            if (!String.IsNullOrEmpty(tbSearchTitle.Text))
                parameters.Add("titre", tbSearchTitle.Text);

            dgvData.DataSource = await DALManager.GetAll<T>(parameters);
            UpdateColumnConfig();
        }

        /// <summary>
        /// Configure les différentes colonnes du DataGridView suite au chargement de données.
        /// </summary>
        private void UpdateColumnConfig()
        {
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvData.Columns["Titre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                bool isVisible = false;
                for (int i = 0; i < DisplayedColumns.Count; i++)
                {
                    if (column.DataPropertyName.Equals(DisplayedColumns[i], StringComparison.OrdinalIgnoreCase))
                    {
                        isVisible = true;
                        break;
                    }
                }

                column.Visible = isVisible;
            }

            dgvData.Columns["Id"].DisplayIndex = 0;
            dgvData.Columns["Titre"].DisplayIndex = 1;
            dgvData.Columns["IdGenre"].HeaderText = "Genre";
            dgvData.Columns["IdRayon"].HeaderText = "Rayon";
            dgvData.Columns["IdPublic"].HeaderText = "Publique";
            isLoading = false;
        }

        /// <summary>
        /// Permet de reformatter le contenu des cellules pour les colonnes Genre, Rayon et Publique afin d'afficher les valeurs textuelles et non les id
        /// </summary>
        private void DgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == dgvData.Columns["IdRayon"].Index ||
                e.ColumnIndex == dgvData.Columns["IdGenre"].Index ||
                e.ColumnIndex == dgvData.Columns["IdPublic"].Index) == false)
                return;

            if (e.Value == null) return;
            T data = dgvData.Rows[e.RowIndex].DataBoundItem as T;
            switch (true)
            {
                case true when e.ColumnIndex == dgvData.Columns["IdRayon"].Index:
                    e.Value = BaseDataManager.GetNameOf<Department>(data.IdRayon);
                    break;

                case true when e.ColumnIndex == dgvData.Columns["IdGenre"].Index:
                    e.Value = BaseDataManager.GetNameOf<Gender>(data.IdGenre);
                    break;

                case true when e.ColumnIndex == dgvData.Columns["IdPublic"].Index:
                    e.Value = BaseDataManager.GetNameOf<Public>(data.IdPublic);
                    break;
            }
        }

        /// <summary>
        /// Gestion générique du tri pour toutes les colonnes lorsque l'utilisateur clique sur un header
        /// </summary>
        private void DgvData_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = dgvData.Columns[e.ColumnIndex];
            string direction;

            List<T> dataList = (List<T>)dgvData.DataSource;
            PropertyInfo sortedProperty = typeof(T).GetProperty(column.DataPropertyName);
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
            dgvData.DataSource = dataList;
        }

        /// <summary>
        /// Déclenchement de l'événement DataSelectionChanged lorsque l'utilisateur sélectionne une donnée
        /// </summary>
        private void DgvData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
                DataSelectionChanged?.Invoke(dgvData.SelectedRows[0].DataBoundItem as T);
            else DataSelectionChanged?.Invoke(null);
        }

        /// <summary>
        /// Déclenche une recherche lorsque l'on clique sur Rechercher
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        /// <summary>
        /// Réinitialise le champs Genre puis redéclenche une recherche lorsque l'on clique sur la croix à droite du control
        /// </summary>
        private void btnDropGender_Click(object sender, EventArgs e)
        {
            cbGender.SelectedIndex = 0;
            SearchData();
        }

        /// <summary>
        /// Réinitialise le champs Publique puis redéclenche une recherche lorsque l'on clique sur la croix à droite du control
        /// </summary>
        private void btnDropPublic_Click(object sender, EventArgs e)
        {
            cbPublic.SelectedIndex = 0;
            SearchData();
        }

        /// <summary>
        /// Réinitialise le champs Rayon puis redéclenche une recherche lorsque l'on clique sur la croix à droite du control
        /// </summary>
        private void btnDropDepartment_Click(object sender, EventArgs e)
        {
            cbDepartment.SelectedIndex = 0;
            SearchData();
        }

        /// <summary>
        /// Déclenche une recherche lorsque l'utilisateur choisit une valeur de genre
        /// </summary>
        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        /// <summary>
        /// Déclenche une recherche lorsque l'utilisateur choisit une valeur de publique
        /// </summary>
        private void cbPublic_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        /// <summary>
        /// Déclenche une recherche lorsque l'utilisateur choisit une valeur de rayon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchData();
        }
    }
}
