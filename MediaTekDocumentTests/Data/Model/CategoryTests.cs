using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocument.Data.Model.Tests
{
    [TestClass()]
    public class CategoryTests
    {
        private const string idEtat = "00001";
        private const string nomEtat = "Suivi";

        private const string idPublic = "10001";
        private const string libellePublic = "Adultes";
        private const string idGenre = "20001";
        private const string libelleGenre = "Horreur";
        private const string idRayon = "30001";
        private const string libelleRayon = "Fruits & légumes";

        private static readonly CommandState commandState = new CommandState(idEtat, nomEtat);
        private static readonly Public @public = new Public(idPublic, libellePublic);
        private static readonly Gender gender = new Gender(idGenre, libelleGenre);
        private static readonly Department department = new Department(idRayon, libelleRayon);

        [TestMethod()]
        public void CategoryTest()
        {
            Assert.AreEqual(idEtat, commandState.Id, "Success : id etat valorisé");
            Assert.AreEqual(nomEtat, commandState.Libelle, "Success : nom état valorisé");

            Assert.AreEqual(idPublic, @public.Id, "Success : id Public valorisé");
            Assert.AreEqual(libellePublic, @public.Libelle, "Success : libellé public valorisé");

            Assert.AreEqual(idGenre, gender.Id, "Success : id Genre valorisé");
            Assert.AreEqual(libelleGenre, gender.Libelle, "Success : libellé genre valorisé");

            Assert.AreEqual(idRayon, department.Id, "Success : id rayon valorisé");
            Assert.AreEqual(libelleRayon, department.Libelle, "Success : libellé rayon valorisé");
        }

        [TestMethod()]
        public void CategoryToStringTest()
        {
            Assert.AreEqual(libelleGenre, gender.ToString(), "Success : La valeur ToString renvoie bien le libellé");
        }
    }
}