using MediaTekDocument.Data.DAL;

namespace MediaTekDocument.Views
{
    /// <summary>
    /// Conteneur principal de l'applicaton
    /// </summary>
    public partial class MediatekContainer : Form
    {
        private Authentication auth;

        public MediatekContainer()
        {
            InitializeComponent();
            RequestAuthentication();

            DALManager.OnError += DALManager_OnError;

        }
        /// <summary>
        /// Affiche l'erreur dans un MessageBox quand une erreur liée au DAL survient
        /// </summary>
        private void DALManager_OnError(Data.Model.Extras.ErrorResponse error)
        {
            MessageBox.Show(error.Error, "Une erreur est survenue");
        }

        /// <summary>
        /// Ouvre la fenêtre d'authentification afin de tenter une authentification
        /// </summary>
        private async void RequestAuthentication()
        {
            await Task.Delay(500);
            auth = new Authentication();
            auth.FormClosed += AuthForm_FormClosed;
            auth.TopLevel = true;
            auth.ShowDialog();

        }

        /// <summary>
        /// Ouvre une fenêtre contenant la liste des abonnements qui expireront dans < 30 jours
        /// </summary>
        private void OpenExpiredReviewList()
        {
            ExpiredReviewList expiredReviewList = new ExpiredReviewList();
            expiredReviewList.ShowDialog();
        }

        /// <summary>
        /// Lorsque la fenêtre d'authentification se ferme, si la réponse à l'authentification est défavorable, on ferme l'application
        /// Sinon on initialise le chargement de l'interface des Livres
        /// </summary>
        private void AuthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (auth.AuthResponse == null)
                Close();
            else
            {
                auth.Dispose();
                auth = null;

                books.LoadData();
                Enabled = true;
            }
        }

        /// <summary>
        /// Quand on change d'interface, en fonction de l'onglet choisit, on déclenche le chargement des données de cette interface
        /// </summary>
        private void tcPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcPages.SelectedIndex)
            {
                case 0:
                    books.LoadData();
                    break;

                case 1:
                    dvds.LoadData();
                    break;

                case 2:
                    reviews.LoadData();
                    break;
            }
        }
    }
}
