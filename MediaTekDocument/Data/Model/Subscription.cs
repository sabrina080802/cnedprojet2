using System.Text.Json.Serialization;

namespace MediaTekDocument.Data.Model
{

    /// <summary>
    /// Modèle des abonnement
    /// </summary>
    public class Subscription
    {
        /// <summary>
        /// Numéro de commande
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Date de fin de l'abonnement
        /// </summary>
        public DateTime DateFinAbonnement { get; set; }

        /// <summary>
        /// Numéro de la revue liée à l'abonnement
        /// </summary>
        public string IdRevue { get; set; }

        /// <summary>
        /// Titre de la revue (pour l'affichage)
        /// </summary>
        [JsonIgnore]
        public string Titre { get; set; }

        internal Subscription() { }
        public Subscription(string id, DateTime dateFinAbonnement, string idRevue)
        {
            this.Id = id;
            this.DateFinAbonnement = dateFinAbonnement;
            this.IdRevue = idRevue;
        }
    }
}
