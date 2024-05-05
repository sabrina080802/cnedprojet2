namespace MediaTekDocument.Views
{
    /// <summary>
    /// Formulaire permettant de demander la date de fin d'un abonnement
    /// </summary>
    public partial class SubscribeSelectEndDateForm : Form
    {
        public DateTime? Result;

        public SubscribeSelectEndDateForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Quand on click sur le bouton Valider, on vérifie que la date indiquée est bien ultérieure à maintenant puis on ferme la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidate_Click(object sender, EventArgs e)
        {
            Result = dtpEndDate.Value;
            if (Result <= DateTime.Now)
            {
                MessageBox.Show("Vous ne pouvez pas mettre une date antérieure", "Erreur");
                return;
            }

            Close();
        }

        /// <summary>
        /// Déclenche la fermeture de la fenêtre quand on clique 
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Result = null;
            Close();
        }
    }
}
