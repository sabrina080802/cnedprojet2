namespace MediaTekDocument.Data.Model.Extras
{
    /// <summary>
    /// Type de réponse à une authentification
    /// </summary>
    public enum AuthResponseType
    {
        Success = 0,
        BadAccount = 1,
        CannotConnect = 2,
        MissingValues = 3,
        AccessDenied = 4
    }

    /// <summary>
    /// Modèle de réponse d'authentification
    /// </summary>
    public class AuthResponse
    {
        /// <summary>
        /// Type de réponse
        /// </summary>
        public AuthResponseType ResponseType { get; set; }
        /// <summary>
        /// Erreur d'authentification
        /// </summary>
        public string Error { get; set; }
        /// <summary>
        /// Si l'authentification réussi, informations du compte
        /// </summary>
        public Account Result { get; set; }
    }
}
