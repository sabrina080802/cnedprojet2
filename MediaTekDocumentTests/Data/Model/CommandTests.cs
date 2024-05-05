using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocument.Data.Model.Tests
{
    [TestClass()]
    public class CommandTests
    {
        private const string id = "00001";
        private static readonly DateTime dateCommande = DateTime.Now;
        private const double montant = 50.0;
        private const byte idSuivi = 2;

        private static readonly Command command = new Command(id, dateCommande, montant, idSuivi);

        [TestMethod()]
        public void CommandTest()
        {
            Assert.AreEqual(id, command.Id, "Success : Id valorisé");
            Assert.AreEqual(dateCommande, command.DateCommande, "Success : date valorisée");
            Assert.AreEqual(montant, command.Montant, "Success : montant valorisé");
            Assert.AreEqual(idSuivi, command.IdSuivi, "Success : id suivi valorisé");
        }
    }
}