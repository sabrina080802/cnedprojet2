using MediaTekDocument.Data.Model;
using MediaTekDocument.Data.Model.Extras;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MediaTekDocument.Data.DAL
{
    /// <summary>
    /// Gestion de l'authentification
    /// </summary>
    public static class AuthManager
    {
        /// <summary>
        /// Tente une authentification et renvoie le résultat
        /// </summary>
        /// <returns>La réponse d'authentification</returns>
        public static async Task<AuthResponse> Connect(string username, string password)
        {
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                return new AuthResponse()
                {
                    ResponseType = AuthResponseType.MissingValues,
                    Error = "Vous devez remplir tous les champs"
                };
            }

            try
            {
                Debug.WriteLine($"Authenticating user {username}:{password}");
                AuthResponse response = await DALManager.Authenticate<AuthResponse>(new Dictionary<string, string>()
                {
                    {"username", username },
                    {"password", password }
                });
                if (response.ResponseType == AuthResponseType.Success)
                    DALManager.SetAuthenticateHeader(username, password);

                return response;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error on trying to request server while authentication");
                return new AuthResponse()
                {
                    ResponseType = AuthResponseType.CannotConnect,
                    Error = "Problème de connexion à la base de données"
                };
            }
        }
    }
}
