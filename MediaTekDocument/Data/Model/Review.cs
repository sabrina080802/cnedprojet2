namespace MediaTekDocument.Data.Model
{
    /// <summary>
    /// Modèle des revues
    /// </summary>
    public class Review : Document
    {
        /// <summary>
        /// Périodicité de parution de la revue
        /// </summary>
        public string Periodicite { get; set; }

        /// <summary>
        /// Délai de mise à disposition d'une revue
        /// </summary>
        public int DelaiMiseADispo { get; set; }

        internal Review() : base() { }
        public Review(string id, string titre, string image, string idRayon, string idPublic, string idGenre, string periodicite, int delaiMiseADispo)
            : base(id, titre, image, idRayon, idPublic, idGenre)
        {
            Periodicite = periodicite;
            DelaiMiseADispo = delaiMiseADispo;
        }
    }
}
