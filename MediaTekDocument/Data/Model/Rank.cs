
namespace MediaTekDocument.Data.Model
{
    /// <summary>
    /// Modèle des rangs d'utilisateur
    /// </summary>
    public class Rank
    {
        /// <summary>
        /// Numéro du rang utilisateur
        /// </summary>
        public byte Id { get; set; }
        /// <summary>
        /// Nom du rang
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Nom affichable du rang
        /// </summary>
        public string FriendlyName { get; set; }

        internal Rank() { }
        public Rank(byte id, string name, string friendlyName)
        {
            Id = id;
            Name = name;
            FriendlyName = friendlyName;
        }
    }
}
