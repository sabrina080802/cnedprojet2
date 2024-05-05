using System.Text.Json.Serialization;

namespace MediaTekDocument.Data.Model.Extras
{
    /// <summary>
    /// Modèle pour la détection d'erreurs sur les requêtes API
    /// </summary>
    public class ErrorResponse
    {
        /// <summary>
        /// Erreur textuelle à afficher à l'utilisateur
        /// </summary>
        [JsonRequired]
        public string Error { get; set; }
    }
}
