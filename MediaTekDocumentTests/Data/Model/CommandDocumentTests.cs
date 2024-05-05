using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocument.Data.Model.Tests
{
    [TestClass()]
    public class CommandDocumentTests
    {
        private const string id = "00001";
        private const int nbExemplaire = 5;
        private const string idLivreDvd = "00005";
        private const string titre = "La belle et la bête";


        private static readonly CommandDocument command = new CommandDocument(id, nbExemplaire, idLivreDvd, titre);

        [TestMethod()]
        public void CommandDocumentTest()
        {
            Assert.AreEqual(id, command.Id, "Success : id valorisé");
            Assert.AreEqual(nbExemplaire, command.NbExemplaire, "Success : Nombre exemplaire valorisé");
            Assert.AreEqual(idLivreDvd, command.IdLivreDvd, "Success : IdLivreDvd valorisé");
            Assert.AreEqual(titre, command.Titre, "Success : titre valorisé");
        }
    }
}