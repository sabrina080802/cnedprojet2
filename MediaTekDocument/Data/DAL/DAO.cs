using MediaTekDocument.Data.Model;

namespace MediaTekDocument.Data.DAL
{
    /// <summary>
    /// Fournit une méthode générique liant une classe à un nom de table
    /// </summary>
    public static class DAO
    {
        private static Dictionary<Type, string> tableNamesByType = new Dictionary<Type, string>()
        {
            {typeof(Dvd), "dvd" },
            {typeof(Book), "livre" },
            {typeof(Review), "revue" },
            {typeof(Public), "public" },
            {typeof(Gender), "genre" },
            {typeof(Department), "rayon" },
            {typeof(Copy), "exemplaire" },
            {typeof(Command), "commande" },
            {typeof(CommandDocument), "commandedocument" },
            {typeof(CommandState), "suivi" },
            {typeof(Subscription), "abonnement" }
        };

        /// <summary>
        /// Renvoie le nom de la table selon le type T fournit
        /// </summary>
        public static string GetTableNameOf<T>()
        {
            Type tType = typeof(T);
            if (tableNamesByType.ContainsKey(tType))
                return tableNamesByType[tType];
            else return String.Empty;
        }
    }
}
