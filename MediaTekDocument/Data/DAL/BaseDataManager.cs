using MediaTekDocument.Data.Model;
using System.Diagnostics;

namespace MediaTekDocument.Data.DAL
{
    /// <summary>
    /// Gestion des données constantes
    /// </summary>
    public static class BaseDataManager
    {
        /// <summary>
        /// Toutes les constantes réunies dans une seule liste
        /// </summary>
        private static List<Category> allCategories = new List<Category>();
        /// <summary>
        /// Liste des genres
        /// </summary>
        public static List<Gender> Genders { get; private set; }
        /// <summary>
        /// Liste des rayons
        /// </summary>
        public static List<Department> Departments { get; private set; }
        /// <summary>
        /// Liste des publiques
        /// </summary>
        public static List<Public> Publics { get; private set; }
        /// <summary>
        /// Liste des états de commandes
        /// </summary>
        public static List<CommandState> CommandStates { get; private set; }

        /// <summary>
        /// Charge la liste des constantes de manière asynchrone
        /// </summary>
        public static async Task Load()
        {
            Debug.WriteLine("Loading Constants data...");
            if (Genders == null)
            {
                Genders = (await DALManager.GetAll<Gender>()).OrderBy(x => x.Libelle).ToList();
                allCategories.AddRange(Genders);
                Genders.Insert(0, new Gender()
                {
                    Libelle = "Tous les genres"
                });
                Debug.WriteLine("\tGenders loaded");
            }


            if (Departments == null)
            {
                Departments = (await DALManager.GetAll<Department>()).OrderBy(x => x.Libelle).ToList();
                allCategories.AddRange(Departments);
                Departments.Insert(0, new Department()
                {
                    Libelle = "Tous les rayons"
                });
                Debug.WriteLine("\tDepartments loaded");
            }

            if (Publics == null)
            {
                Publics = (await DALManager.GetAll<Public>()).OrderBy(x => x.Libelle).ToList();
                allCategories.AddRange(Publics);
                Publics.Insert(0, new Public()
                {
                    Libelle = "Tous les publics"
                });
                Debug.WriteLine("\tPublics loaded");
            }

            if (CommandStates == null)
            {
                CommandStates = (await DALManager.GetAll<CommandState>()).OrderBy(x => x.Id).ToList();
                allCategories.AddRange(CommandStates);

                Debug.WriteLine("\tCommand states loaded");
            }
        }

        /// <summary>
        /// Récupère le libellé d'une constante selon son numéro
        /// </summary>
        /// <typeparam name="T">Le type de constante</typeparam>
        /// <param name="id">Le numéro de la constante</param>
        public static string GetNameOf<T>(string id)
            where T : Category
        {
            Type tType = typeof(T);
            try
            {
                return allCategories.First(x => x.GetType() == tType && x.Id.Equals(id)).Libelle;
            }
            catch
            {
                return null;
            }
        }
    }
}
