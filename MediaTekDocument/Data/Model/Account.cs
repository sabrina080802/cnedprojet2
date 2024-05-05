namespace MediaTekDocument.Data.Model
{
    /// <summary>
    /// Modèles des comptes utilisateurs
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Numéro du compte
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nom de compte utilisé pour se connecté
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Rang de l'utilisateur
        /// </summary>
        public Rank Rank { get; set; }

        internal Account() { }
        public Account(int id, string username, Rank rank)
        {
            Id = id;
            Username = username;
            Rank = rank;
        }
    }
}
