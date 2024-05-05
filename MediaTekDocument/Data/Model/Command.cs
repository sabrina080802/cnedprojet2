namespace MediaTekDocument.Data.Model
{
    /// <summary>
    /// Modèle des commandes
    /// </summary>
    public class Command
    {
        /// <summary>
        /// Numéro de la commande
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Date de la commande
        /// </summary>
        public DateTime DateCommande { get; set; }

        /// <summary>
        /// Montant de la commande
        /// </summary>
        public double Montant { get; set; }

        /// <summary>
        /// Numéro d'état de suivi de la commande
        /// </summary>
        public byte IdSuivi { get; set; }

        internal Command() { }
        public Command(string id, DateTime dateCommande, double montant, byte idSuivi)
        {
            Id = id;
            DateCommande = dateCommande;
            Montant = montant;
            IdSuivi = idSuivi;
        }
    }
}
