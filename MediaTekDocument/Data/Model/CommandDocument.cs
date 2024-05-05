using System.Text.Json.Serialization;

namespace MediaTekDocument.Data.Model
{
    /// <summary>
    /// Modèle des documents liés à une commande (commandedocument)
    /// </summary>
    public class CommandDocument
    {
        /// <summary>
        /// Numéro de la commande
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Nombre d'exemplaire du livre ou DVD pour cette commande
        /// </summary>
        public int NbExemplaire { get; set; }
        /// <summary>
        /// Numéro du livre ou DVD
        /// </summary>
        public string IdLivreDvd { get; set; }

        /// <summary>
        /// Titre du livre ou DVD (pour l'affichage uniquement)
        /// </summary>
        public string Titre { get; set; }


        internal CommandDocument() { }
        public CommandDocument(string id, int nbExemplaire, string idLivreDvd, string titre)
        {
            Id = id;
            NbExemplaire = nbExemplaire;
            IdLivreDvd = idLivreDvd;
            Titre = titre;
        }
    }
}
