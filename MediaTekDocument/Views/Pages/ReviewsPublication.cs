using MediaTekDocument.Data.DAL;
using MediaTekDocument.Data.Model;
using System.Data;
using System.Reflection;

namespace MediaTekDocument.Views.Pages
{
    /// <summary>
    /// UserControl contenant la gestion de la parution des revues
    /// </summary>
    public partial class ReviewsPublication : UserControl
    {
        private string currentCopiesSort;

        private Review currentReview;
        private Copy currentCopy;

        public ReviewsPublication()
        {
            InitializeComponent();
            UpdateFields();
        }

        /// <summary>
        /// Gestion générique du tri
        /// </summary>
        private void DgvPublications_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = dgvPublications.Columns[e.ColumnIndex];
            string direction;

            List<Copy> dataList = (List<Copy>)dgvPublications.DataSource;
            PropertyInfo sortedProperty = typeof(Copy).GetProperty(column.DataPropertyName);
            if (currentCopiesSort == column.DataPropertyName + " ASC")
            {
                direction = "DESC";
                dataList = dataList.OrderBy(x => sortedProperty.GetValue(x)).Reverse().ToList();
            }
            else
            {
                direction = "ASC";
                dataList = dataList.OrderBy(x => sortedProperty.GetValue(x)).ToList();
            }

            currentCopiesSort = $"{column.DataPropertyName} {direction}";
            dgvPublications.DataSource = dataList;
        }

        /// <summary>
        /// Déclenche la recherche d'une revue
        /// </summary>
        private async void btnSearchReview_Click(object sender, EventArgs e)
        {
            currentReview = await DALManager.Get<Review>(tbReviewId.Text);
            UpdateFields();
            if (currentReview == null)
            {
                MessageBox.Show("Aucune revue trouvée à ce numéro", "Revue introuvable");
                return;
            }
        }

        /// <summary>
        /// Met à jour le contenu du formulaire selon les informations de la revue recherchée
        /// </summary>
        private async void UpdateFields()
        {
            if (currentReview != null)
            {
                tbTitle.Text = currentReview.Titre;
                tbPeriodicity.Text = currentReview.Periodicite;
                tbDelay.Text = currentReview.DelaiMiseADispo.ToString();
                tbGender.Text = BaseDataManager.GetNameOf<Gender>(currentReview.IdGenre);
                tbDepartment.Text = BaseDataManager.GetNameOf<Department>(currentReview.IdRayon);
                tbPublic.Text = BaseDataManager.GetNameOf<Public>(currentReview.IdPublic);
                tbImagePath.Text = currentReview.Image;
                dgvPublications.DataSource = await DALManager.GetAll<Copy>(new Dictionary<string, string>()
                {
                    {"id", currentReview.Id}
                });
            }
            else
            {
                tbTitle.Text = string.Empty;
                tbPeriodicity.Text = string.Empty;
                tbDelay.Text = string.Empty;
                tbGender.Text = string.Empty;
                tbDepartment.Text = string.Empty;
                tbPublic.Text = string.Empty;
                tbImagePath.Text = string.Empty;
                dgvPublications.DataSource = new List<Copy>();
            }
            dgvPublications.Columns["Id"].Visible = false;
            dgvPublications.Columns["IdEtat"].Visible = false;
            dgvPublications.Columns["Photo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPublications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Met à jour les control en fonction de l'exemplaire de revue sélectionnée par l'utilisateur
        /// </summary>
        private void dgvPublications_SelectionChanged(object sender, EventArgs e)
        {
            currentCopy = (dgvPublications.SelectedRows.Count > 0 ? dgvPublications.SelectedRows[0].DataBoundItem as Copy : null);
            if (currentCopy != null)
            {
                tbNewRevNumber.Text = currentCopy.Numero.ToString();
                tbNewRevImagePath.Text = currentCopy.Photo;
                dtpNewRevPublishDate.Value = currentCopy.DateAchat;
            }
            else
            {
                tbNewRevImagePath.Text = string.Empty;
                tbNewRevNumber.Text = string.Empty;
                dtpNewRevPublishDate.Value = DateTime.Now;
            }
        }
    }
}
