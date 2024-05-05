namespace MediaTekDocument.Data.Model
{
    /// <summary>
    /// Modèle des exemplaires de revue
    /// </summary>
    public class Copy
    {
        /// <summary>
        /// Numéro d'exemplaire
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Numéro du document de l'exemplaire
        /// </summary>
        public int Numero { get; set; }
        /// <summary>
        /// Photo spécifique à l'exemplaire
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// Date d'achat de l'exemplaire
        /// </summary>
        public DateTime DateAchat { get; set; }
        /// <summary>
        /// Numéro de l'état de l'exemplaire
        /// </summary>
        public string IdEtat { get; set; }

        internal Copy() { }
        public Copy(string id, int numero, string photo, DateTime dateAchat, string idEtat)
        {
            Id = id;
            Numero = numero;
            Photo = photo;
            DateAchat = dateAchat;
            IdEtat = idEtat;
        }
    }
}
