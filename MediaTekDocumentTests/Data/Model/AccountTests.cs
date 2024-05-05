using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocument.Data.Model.Tests
{
    [TestClass()]
    public class AccountTests
    {
        private const int id = 1;
        private const string username = "Jean-Mohammed";

        private static readonly Rank rank = new Rank(0, "Administrateur", "admin");
        private static readonly Account account = new Account(id, username, rank);

        [TestMethod()]
        public void AccountTest()
        {
            Assert.AreEqual(id, account.Id, "Success : id valorisé");
            Assert.AreEqual(username, account.Username, "Success : username valorisé");
            Assert.AreEqual(rank, account.Rank, "Success : rank valorisé");
        }
    }
}