using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocument.Data.Model.Tests
{
    [TestClass()]
    public class DvdTests
    {
        /** Document data */
        private const string id = "00001";
        private const string title = "Mon super livre";
        private const string image = "/mon-super-chemin/vers-mon-image.png";
        private const string idRayon = "00005";
        private const string idPublic = "10005";
        private const string idGenre = "20005";

        private const string synopsis = "Il était une fois un super DVD";
        private const string realisateur = "Christopher Local";
        private const int duree = 50;

        private static readonly Dvd dvd = new Dvd(id, title, image, idRayon, idPublic, idGenre, synopsis, realisateur, duree);

        [TestMethod()]
        public void DvdTest()
        {
            Assert.AreEqual(id, dvd.Id, "Success : id valorisé");
            Assert.AreEqual(title, dvd.Titre, "Success : titre valorisé");
            Assert.AreEqual(image, dvd.Image, "Success : image valorisé");
            Assert.AreEqual(idRayon, dvd.IdRayon, "Success : idRayon valorisé");
            Assert.AreEqual(idPublic, dvd.IdPublic, "Success : idPublic valorisé");
            Assert.AreEqual(idGenre, dvd.IdGenre, "Success : idGenre valorisé");

            Assert.AreEqual(synopsis, dvd.Synopsis, "Success : synopsis valorisé");
            Assert.AreEqual(realisateur, dvd.Realisateur, "Success : synopsis valorisé");
            Assert.AreEqual(duree, dvd.Duree, "Success : durée valorisé");
        }
    }
}