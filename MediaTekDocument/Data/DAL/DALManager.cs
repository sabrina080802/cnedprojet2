using MediaTekDocument.Data.Model.Extras;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MediaTekDocument.Data.DAL
{
    /// <summary>
    /// Gestion des requêtes API
    /// </summary>
    public static class DALManager
    {
        /// <summary>
        /// Delegate qui sert au déclenchement d'événement lorsqu'une erreur lié à l'API survient
        /// </summary>
        public delegate void ErrorDelegateEvent(ErrorResponse error);
        /// <summary>
        /// Evénement déclenché lorsqu'une erreur est renvoyée par l'API
        /// </summary>
        public static event ErrorDelegateEvent OnError;

        /// <summary>
        /// Host d'accès à l'API
        /// </summary>
        private const string HostApi = "mediatek-document.great-site.net";
        //private const string HostApi = "sabrina_ap3.local";

        /// <summary>
        /// Url de base d'accès à l'API
        /// </summary>
        private const string UriApi = $"http://{HostApi}/";
        /// <summary>
        /// Extension à l'URL d'accès à l'API. Laisser vide si inutilisé
        /// </summary>
        private const string UriExtension = "";

        /// <summary>
        /// Options d'interprétation du JSON
        /// </summary>
        private static readonly JsonSerializerOptions jsonDeserializerOptions;
        /// <summary>
        /// Option de compilation du JSON
        /// </summary>
        private static readonly JsonSerializerOptions jsonSerializerOptions;

        /// <summary>
        /// Client HTTP utilisé pour émettre les requêtes
        /// </summary>
        private static readonly HttpClient client;


        /// <summary>
        /// Constructeur static qui s'exécute dès le premier appel de DALManager
        /// Initialise le client et les options pour l'interprétation et la compilation de JSON
        /// </summary>
        static DALManager()
        {
            Debug.WriteLine("Initializing HttpClient");
            client = new HttpClient()
            {
                //Préparation de l'URL de base d'accès à l'API
                BaseAddress = new Uri(new Uri(UriApi), UriExtension)
            };
            jsonDeserializerOptions = new JsonSerializerOptions()
            {
                //Définit que l'interprétation de JSON n'est pas sensible à la casse
                PropertyNameCaseInsensitive = true,
                //Autorise l'interpréteur JSON à parser les nombres inclut dans des chaînes de caractères
                NumberHandling = JsonNumberHandling.AllowReadingFromString
            };

            jsonSerializerOptions = new JsonSerializerOptions()
            {
                //Autorise le compileur JSON à fournir des chaînes de caractères au lieu de nombres
                NumberHandling = JsonNumberHandling.AllowReadingFromString,
                //Indique au compileur JSON d'ignorer les propriétés qui sont en lecture seule
                IgnoreReadOnlyProperties = true
            };
        }

        /// <summary>
        /// Dès que l'utilisateur est authentifié, on génère un ConnectionString que l'on encode en Base64
        /// Un header est définit par défaut pour que toutes les prochaines requêtes l'incluent.
        /// </summary>
        public static void SetAuthenticateHeader(string username, string password)
        {
            Debug.WriteLine("Authenticated, setting Authorization header");
            string b64AuthString = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes($"{username}:{password}"));
            client.DefaultRequestHeaders.Add("Authorization", $"Basic {b64AuthString}");
        }

        /// <summary>
        /// Récupère une liste de données de type T selon les paramètres fournit
        /// </summary>
        /// <typeparam name="T">Le type de données attendu</typeparam>
        /// <param name="parameters">(optionnel) Les paramètres fournit pour réaliser la recherche</param>
        public static async Task<List<T>> GetAll<T>(Dictionary<string, string> parameters = null)
            where T : class
        {
            string request = '/' + AppendParametersToURL(DAO.GetTableNameOf<T>(), parameters);

            using (HttpResponseMessage response = await client.GetAsync(request))
            {
                try
                {
                    string result = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine($">> GET(All) {request} : [code={response.StatusCode}] ; result = {result}");
                    return new List<T>(JsonSerializer.Deserialize<T[]>(result, jsonDeserializerOptions));
                }
                catch (Exception e)
                {
                    Debug.WriteLine($">> GET(All) {request} : [code={response.StatusCode}] ; FAIL");
                    return new List<T>();
                }
            }
        }
        /// <summary>
        /// Récupère une unique donnée de type T selon l'id fournit
        /// </summary>
        /// <typeparam name="T">Le type de données attendu</typeparam>
        /// <param name="id">L'id de la donné</param>
        public static async Task<T> Get<T>(string id)
        {
            string request = $"/{DAO.GetTableNameOf<T>()}/{id}";
            using (HttpResponseMessage response = await client.GetAsync(request))
            {
                string result = await response.Content.ReadAsStringAsync();
                try
                {
                    Debug.WriteLine($">> GET {request} : [code={response.StatusCode}] ; result = {result}");
                    return JsonSerializer.Deserialize<T>(result, jsonDeserializerOptions);
                }
                catch
                {
                    Debug.WriteLine($">> GET {request} : [code={response.StatusCode}] ; FAIL");
                    return default;
                }
            }
        }

        /// <summary>
        /// Emet une requête de type Post pour créer une donnée du type attendu en utilisant les données fournies
        /// </summary>
        /// <typeparam name="T">Le type de la donnée créée</typeparam>
        /// <param name="parameters">Paramètres fournis pour la création de la donnée</param>
        /// <returns>La donnée complète avec les valeurs par défaut</returns>
        public static async Task<T> Post<T>(Dictionary<string, string> parameters)
        {
            MultipartFormDataContent content = null;
            string data = string.Empty;
            string request = DAO.GetTableNameOf<T>();
            if (parameters != null && parameters.Count > 0)
            {
                data = JsonSerializer.Serialize(parameters, jsonSerializerOptions);
                content = new MultipartFormDataContent()
                {
                    {new StringContent(request), "table" },
                    {new StringContent(data), "champs" }
                };
            }

            using (HttpResponseMessage response = await client.PostAsync($"/{request}", content))
            {
                string result = await response.Content.ReadAsStringAsync();
                try
                {
                    Debug.WriteLine($">> POST /{request} : [code={response.StatusCode}] ; result={result}");
                    return JsonSerializer.Deserialize<T>(result, jsonDeserializerOptions);
                }
                catch (Exception e)
                {
                    Debug.WriteLine($">> POST /{request} : [code={response.StatusCode}] ; FAIL");
                    return default;
                }
            }
        }

        /// <summary>
        /// Emet une requête Post sur une URL personnalisé, n'est utilisé que pour l'authentificatin
        /// </summary>
        /// <typeparam name="T">Le type de donnée attendu</typeparam>
        public static async Task<T> Authenticate<T>(Dictionary<string, string> parameters = null)
        {
            string request = "/auth";
            MultipartFormDataContent content = null;
            if (parameters != null && parameters.Count > 0)
            {
                content = new MultipartFormDataContent();
                foreach (KeyValuePair<string, string> data in parameters)
                    content.Add(new StringContent(data.Value), data.Key);
            }

            using (HttpResponseMessage response = await client.PostAsync(request, content))
            {
                string data = await response.Content.ReadAsStringAsync();
                try
                {
                    Debug.WriteLine($">> POST(Auth) : [code={response.StatusCode}] ; result={data}");
                    return JsonSerializer.Deserialize<T>(data, jsonDeserializerOptions);
                }
                catch (Exception e)
                {
                    Debug.WriteLine($">> POST(Auth) : [code={response.StatusCode}] ; Failed to handle data \"{data}\"");
                    return default;
                }
            }
        }

        /// <summary>
        /// Emet une requête POST pour créer une donnée de type T auprès de l'API
        /// </summary>
        /// <typeparam name="T">Le type de donnée attendu</typeparam>
        /// <param name="data">La donnée à créer</param>
        /// <returns>La donnée complète</returns>
        public static async Task<T> Post<T>(T data)
        {
            string request = DAO.GetTableNameOf<T>();
            MultipartFormDataContent content = new MultipartFormDataContent
            {
                { new StringContent(request), "table" },
                { new StringContent(JsonSerializer.Serialize(data, jsonSerializerOptions)), "champs" }
            };

            using (HttpResponseMessage response = await client.PostAsync("/" + request, content))
            {
                try
                {
                    response.EnsureSuccessStatusCode();
                    string result = await response.Content.ReadAsStringAsync();
                    try
                    {
                        ErrorResponse error = JsonSerializer.Deserialize<ErrorResponse>(result, jsonDeserializerOptions);
                        if (error != null)
                        {
                            OnError?.Invoke(error);
                            Debug.WriteLine($">> POST /{request} : [code={response.StatusCode}] ; error={error.Error}");
                            return default;
                        }
                        else
                        {
                            Debug.WriteLine($">> POST /{request} : [code={response.StatusCode}] ; result={result}");

                            return JsonSerializer.Deserialize<T>(result, jsonDeserializerOptions);
                        }
                    }
                    catch
                    {
                        Debug.WriteLine($">> POST /{request} : [code={response.StatusCode}] ; result={result}");
                        return JsonSerializer.Deserialize<T>(result, jsonDeserializerOptions);
                    }
                }
                catch
                {
                    Debug.WriteLine($">> POST /{request} : [code={response.StatusCode}] ; FAIL");
                    return default;
                }
            }
        }

        /// <summary>
        /// Emet une requête UPDATE pour mettre à jour les données lié à un id.
        /// </summary>
        /// <typeparam name="T">Le type de donnée à mettre à jour</typeparam>
        /// <param name="id">L'id de la donnée à mettre à jour</param>
        /// <param name="parameters">Les paramètres à modifier</param>
        /// <returns>Un booléan indiquant si la mise à jour à réussi</returns>
        public static async Task<bool> Update<T>(string id, Dictionary<string, string> parameters)
        {
            string requestData = JsonSerializer.Serialize(parameters, jsonSerializerOptions);
            string request = DAO.GetTableNameOf<T>();
            MultipartFormDataContent content = new MultipartFormDataContent
            {
                { new StringContent(request), "table" },
                {new StringContent(id), "id" },
                { new StringContent(requestData), "champs" }
            };

            using (HttpResponseMessage response = await client.PutAsync($"/{request}", content))
            {
                try
                {
                    response.EnsureSuccessStatusCode();
                    string result = await response.Content.ReadAsStringAsync();
                    try
                    {
                        ErrorResponse error = JsonSerializer.Deserialize<ErrorResponse>(result, jsonDeserializerOptions);
                        if (error != null)
                        {
                            OnError?.Invoke(error);
                            Debug.WriteLine($">> PUT /{request} : [code={response.StatusCode}, data={requestData}] ; error={error.Error}");
                            return false;
                        }
                        else
                        {
                            Debug.WriteLine($">> PUT /{request} : [code={response.StatusCode}, data={requestData}] : SUCCESS");
                            return true;
                        }
                    }
                    catch
                    {
                        Debug.WriteLine($">> PUT /{request} : [code={response.StatusCode}, data={requestData}] : SUCCESS");
                        return true;
                    }
                }
                catch
                {
                    Debug.WriteLine($">> PUT /{request} : [code={response.StatusCode}, data={requestData}] : Failed");
                    return false;
                }
            }
        }

        /// <summary>
        /// Emet une requête UPDATE pour mettre à jour la donnée fournie
        /// </summary>
        /// <typeparam name="T">Le type de donnée à mettre à jour</typeparam>
        /// <param name="data">La donnée à mettre à jour</param>
        /// <returns>Un booléan indiquant si la requête à réussi</returns>
        public static async Task<bool> Update<T>(T data)
        {
            string request = DAO.GetTableNameOf<T>();
            string requestData = JsonSerializer.Serialize(data, jsonSerializerOptions);
            MultipartFormDataContent content = new MultipartFormDataContent
            {
                { new StringContent(request), "table" },
                { new StringContent((string)typeof(T).GetProperty("Id").GetValue(data)), "id" },
                { new StringContent(requestData), "champs" }
            };

            using (HttpResponseMessage response = await client.PutAsync($"/{request}", content))
            {
                try
                {
                    response.EnsureSuccessStatusCode();
                    string result = await response.Content.ReadAsStringAsync();
                    try
                    {
                        ErrorResponse error = JsonSerializer.Deserialize<ErrorResponse>(result, jsonDeserializerOptions);
                        if (error != null)
                        {
                            OnError?.Invoke(error);
                            Debug.WriteLine($">> PUT /{request} : [code={response.StatusCode}, data={requestData}] : Failed with error \"{error.Error}\"");
                            return false;
                        }
                        else
                        {
                            Debug.WriteLine($">> PUT /{request} : [code={response.StatusCode}, data={requestData}] : SUCCESS");
                            return true;
                        }
                    }
                    catch
                    {
                        Debug.WriteLine($">> PUT /{request} : [code={response.StatusCode}, data={requestData}] : SUCCESS");
                        return true;
                    }
                }
                catch
                {
                    Debug.WriteLine($">> PUT /{request} : [code={response.StatusCode}, data={requestData}] : Failed");
                    return false;
                }
            }
        }

        /// <summary>
        /// Emet une requête de type DELETE pour supprimer une donnée auprès de l'API
        /// </summary>
        /// <typeparam name="T">Le type de donnée à supprimer</typeparam>
        /// <param name="data">La donnée à supprimer</param>
        /// <returns>Un booléen indiquant si la suppression a réussi ou non</returns>
        public static async Task<bool> Delete<T>(T data)
        {
            string request = new StringBuilder()
                .Append('/').Append(DAO.GetTableNameOf<T>())
                .Append('/').Append((string)typeof(T).GetProperty("Id").GetValue(data))
                .ToString();

            using (HttpResponseMessage response = await client.DeleteAsync(request))
            {
                try
                {
                    response.EnsureSuccessStatusCode();
                    string result = await response.Content.ReadAsStringAsync();
                    try
                    {
                        ErrorResponse error = JsonSerializer.Deserialize<ErrorResponse>(result, jsonDeserializerOptions);
                        if (error != null)
                        {
                            OnError?.Invoke(error);
                            Debug.WriteLine($">> DELETE {request} : [code={response.StatusCode}] : Failed with error \"{error.Error}\"");
                            return false;
                        }
                        else
                        {
                            Debug.WriteLine($">> DELETE {request} : [code={response.StatusCode}] : SUCCESS");
                            return true;
                        }
                    }
                    catch
                    {
                        Debug.WriteLine($">> DELETE /{request} : [code={response.StatusCode}] : SUCCESS");
                        return true;
                    }
                }
                catch
                {
                    Debug.WriteLine($">> DELETE /{request} : [code={response.StatusCode}] : Fail");
                    return false;
                }
            }
        }

        /// <summary>
        /// Modifie l'URL afin d'ajouter les paramètres en GET
        /// La méthode est en inline pour des raisons d'optimisation
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string AppendParametersToURL(string request, Dictionary<string, string> parameters)
        {
            if (parameters != null && parameters.Count > 0)
            {
                request = new StringBuilder(request)
                    .Append("/")
                    .Append(JsonSerializer.Serialize(parameters))
                    .ToString();
            }

            return request;
        }
    }
}
