namespace MediaTekDocument.Data.Model
{
    /// <summary>
    /// Modèle de base des données constantes (publique, genre, rayon, état de commande)
    /// </summary>
    public abstract class Category
    {
        /// <summary>
        /// Numéro de la donnée
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Libellé de la donnée (pour l'affichage)
        /// </summary>
        public string Libelle { get; set; }

        internal Category() { }
        public Category(string id, string libelle)
        {
            Id = id;
            Libelle = libelle;
        }

        /// <summary>
        /// Retourne la valeur du libellé
        /// </summary>
        public new string ToString()
            => Libelle;
    }

    /// <summary>
    /// Modèle des publiques
    /// </summary>
    public class Public : Category
    {
        internal Public() { }
        public Public(string id, string libelle) : base(id, libelle) { }
    }

    /// <summary>
    /// Modèle des genres
    /// </summary>
    public class Gender : Category
    {
        internal Gender() { }
        public Gender(string id, string libelle) : base(id, libelle) { }
    }

    /// <summary>
    /// Modèle des rayons
    /// </summary>
    public class Department : Category
    {
        internal Department() { }
        public Department(string id, string libelle) : base(id, libelle) { }
    }

    /// <summary>
    /// Modèle des états de commande
    /// </summary>
    public class CommandState : Category
    {
        internal CommandState() { }
        public CommandState(string id, string libelle) : base(id, libelle) { }
    }

}
