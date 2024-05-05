namespace MediaTekDocument.Data.Model
{
    /// <summary>
    /// Modèle des DVD
    /// </summary>
    public class Dvd : Document
    {
        /// <summary>
        /// Synopsis du document
        /// </summary>
        public string Synopsis { get; set; }
        /// <summary>
        /// Qui a réalisé ce DVD
        /// </summary>
        public string Realisateur { get; set; }
        /// <summary>
        /// Durée du DVD
        /// </summary>
        public int Duree { get; set; }

        internal Dvd() : base() { }
        public Dvd(string id, string titre, string image, string idRayon, string idPublic, string idGenre, string synopsis, string realisateur, int duree)
            : base(id, titre, image, idRayon, idPublic, idGenre)
        {
            Synopsis = synopsis;
            Realisateur = realisateur;
            Duree = duree;
        }
    }
}
