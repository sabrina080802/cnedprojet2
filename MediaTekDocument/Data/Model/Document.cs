namespace MediaTekDocument.Data.Model
{
    /// <summary>
    /// Modèle des Documents, sert de base pour les livres, dvd et revues
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Numéro du document
        /// </summary>
        public string Id { get; private set; }
        /// <summary>
        /// Titre du document
        /// </summary>
        public string Titre { get; set; }
        /// <summary>
        /// Image du document
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// Rayon où se trouve le document
        /// </summary>
        public string IdRayon { get; set; }
        /// <summary>
        /// Publique cible du document
        /// </summary>
        public string IdPublic { get; set; }
        /// <summary>
        /// Genre du document
        /// </summary>
        public string IdGenre { get; set; }

        internal Document() { }
        public Document(string id, string titre, string image, string idRayon, string idPublic, string idGenre)
        {
            Id = id;
            Titre = titre;
            Image = image;
            IdRayon = idRayon;
            IdPublic = idPublic;
            IdGenre = idGenre;
        }
    }
}
