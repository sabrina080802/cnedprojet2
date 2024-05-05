using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocument.Data.Model.Tests
{
    [TestClass()]
    public class ReviewTests
    {
        /** Document data */
        private const string id = "00001";
        private const string title = "Mon super livre";
        private const string image = "/mon-super-chemin/vers-mon-image.png";
        private const string idRayon = "00005";
        private const string idPublic = "10005";
        private const string idGenre = "20005";

        /** Review data */
        private const string periodicite = "MS";
        private const int delaiMiseADispo = 5;

        private static readonly Review review = new Review(id, title, image, idRayon, idPublic, idGenre, periodicite, delaiMiseADispo);

        [TestMethod()]
        public void ReviewTest()
        {
            Assert.AreEqual(id, review.Id, "Success : id valorisé");
            Assert.AreEqual(title, review.Titre, "Success : titre valorisé");
            Assert.AreEqual(image, review.Image, "Success : image valorisé");
            Assert.AreEqual(idRayon, review.IdRayon, "Success : idRayon valorisé");
            Assert.AreEqual(idPublic, review.IdPublic, "Success : idPublic valorisé");
            Assert.AreEqual(idGenre, review.IdGenre, "Success : idGenre valorisé");

            Assert.AreEqual(periodicite, review.Periodicite, "Success : periodicité valorisée");
            Assert.AreEqual(delaiMiseADispo, review.DelaiMiseADispo, "Success : delai mise à dispo valorisée");
        }
    }
}