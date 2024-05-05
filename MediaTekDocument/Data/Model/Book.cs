namespace MediaTekDocument.Data.Model
{
    /// <summary>
    /// Modèle des livres
    /// </summary>
    public class Book : Document
    {
        /// <summary>
        /// ISBN du livre
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// Auteur du livre
        /// </summary>
        public string Auteur { get; set; }
        /// <summary>
        /// Collection dans laquelle se trouve le livre
        /// </summary>
        public string Collection { get; set; }

        internal Book() : base() { }
        public Book(string id, string titre, string image, string idRayon, string idPublic, string idGenre, string iSBN, string auteur, string collection)
            : base(id, titre, image, idRayon, idPublic, idGenre)
        {
            ISBN = iSBN;
            Auteur = auteur;
            Collection = collection;
        }
    }
}
