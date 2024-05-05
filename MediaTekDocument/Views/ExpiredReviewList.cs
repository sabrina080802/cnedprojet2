using MediaTekDocument.Data.DAL;
using MediaTekDocument.Data.Model;
using System.Data;
using System.Reflection;

namespace MediaTekDocument.Views
{
    /// <summary>
    /// Form qui affiche la liste des abonnements qui vont expirer dans les 30 prochains jours
    /// </summary>
    public partial class ExpiredReviewList : Form
    {
        /// <summary>
        /// Formule actuelle du tri
        /// </summary>
        private string currentSort;

        public ExpiredReviewList()
        {
            InitializeComponent();
            LoadData();
        }

        /// <summary>
        /// Triage générique de toutes les colonnes lorsque l'on clique sur un header
        /// </summary>
        private void DgvData_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = dgvSubscriptionList.Columns[e.ColumnIndex];
            string direction;

            List<Subscription> dataList = (List<Subscription>)dgvSubscriptionList.DataSource;
            PropertyInfo sortedProperty = typeof(Subscription).GetProperty(column.DataPropertyName);
            if (currentSort == column.DataPropertyName + " ASC")
            {
                direction = "DESC"; //Décroissant
                dataList = dataList.OrderBy(x => sortedProperty.GetValue(x)).Reverse().ToList();
            }
            else
            {
                direction = "ASC"; //Croissant
                dataList = dataList.OrderBy(x => sortedProperty.GetValue(x)).ToList();
            }

            currentSort = $"{column.DataPropertyName} {direction}";
            dgvSubscriptionList.DataSource = dataList;
        }

        /// <summary>
        /// Déclenche le chargement asynchrone des données. Les défini en tant que DataSource du DataGridView
        /// et traite les paramètres des colonnes
        /// </summary>
        private async void LoadData()
        {
            dgvSubscriptionList.DataSource = await DALManager.GetAll<Subscription>(new Dictionary<string, string>
            {
                {"dateFinAbonnement", (DateTime.Now + TimeSpan.FromDays(30)).ToString("yyyy-M-d") }
            });

            dgvSubscriptionList.Columns["Titre"].DisplayIndex = 1;
            dgvSubscriptionList.Columns["DateFinAbonnement"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSubscriptionList.Columns["IdRevue"].Visible = false;
        }

        /// <summary>
        /// Ferme la fenêtre quand on clique sur le bouton fermer
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
