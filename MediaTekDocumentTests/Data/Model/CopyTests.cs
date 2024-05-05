using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocument.Data.Model.Tests
{
    [TestClass()]
    public class CopyTests
    {
        private const string id = "00005";
        private const int numero = 5;
        private const string photo = "/ma-super-photo.png";
        private static readonly DateTime dateAchat = DateTime.Now;
        private const string idEtat = "00001";

        private static readonly Copy copy = new Copy(id, numero, photo, dateAchat, idEtat);

        [TestMethod()]
        public void CopyTest()
        {
            Assert.AreEqual(id, copy.Id, "Success : id valorisé");
            Assert.AreEqual(numero, copy.Numero, "Success : numéro valorisé");
            Assert.AreEqual(photo, copy.Photo, "Success : photo valorisé");
            Assert.AreEqual(dateAchat, copy.DateAchat, "Success : date achat valorisé");
            Assert.AreEqual(idEtat, copy.IdEtat, "Success : idEtat valorisé");
        }
    }
}