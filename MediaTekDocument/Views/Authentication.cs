using MediaTekDocument.Data.DAL;
using MediaTekDocument.Data.Model.Extras;

namespace MediaTekDocument.Views
{
    /// <summary>
    /// Fenêtre d'authentification
    /// </summary>
    public partial class Authentication : Form
    {
        /// <summary>
        /// Résultat renvoyé par l'authentification
        /// </summary>
        public AuthResponse AuthResponse { get; private set; }

        /// <summary>
        /// Lors de la création, une authentification automatique est tentée avec les informations trouvées dans les préférences Utilisateur
        /// </summary>
        public Authentication()
        {
            InitializeComponent();
            tbUsername.Text = Properties.Settings.Default.Username;
            tbPassword.Text = Properties.Settings.Default.Password;

            //if (!String.IsNullOrEmpty(tbUsername.Text) && !String.IsNullOrEmpty(tbPassword.Text))
            //Authenticate();
        }

        /// <summary>
        /// Quand on clique sur le bouton Connexion, on tente une authentification
        /// </summary>
        private void btnConnect_MouseClick(object sender, MouseEventArgs e)
        {
            Authenticate();
        }

        /// <summary>
        /// Tente une authentification à partir des informations entrées par l'utilisateur.
        /// Si l'authentification échoue, on affiche un message d'erreur.
        /// Si l'authentification réussie, on sauvegarde les informations dans les préférences utilisateur puis on ferme la fenêtre
        /// </summary>
        private async void Authenticate()
        {
            btnConnect.Enabled = false;

            tbUsername.ReadOnly = true;
            tbPassword.ReadOnly = true;

            AuthResponse = await AuthManager.Connect(tbUsername.Text, tbUsername.Text);
            if (AuthResponse.ResponseType != AuthResponseType.Success)
            {
                MessageBox.Show(AuthResponse.Error, "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnConnect.Enabled = true;
                tbUsername.ReadOnly = false;
                tbPassword.ReadOnly = false;
                AuthResponse = null;
                return;
            }

            Properties.Settings.Default.Username = tbUsername.Text;
            Properties.Settings.Default.Password = tbPassword.Text;
            Properties.Settings.Default.Save();

            this.Close();
        }
    }
}
