using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocument.Data.Model.Tests
{
    [TestClass()]
    public class RankTests
    {
        private const byte id = 5;
        private const string name = "Admin";
        private const string friendlyName = "Administrateur";

        private static readonly Rank rank = new Rank(id, name, friendlyName);

        [TestMethod()]
        public void RankTest()
        {
            Assert.AreEqual(id, rank.Id, "Success : id valorisé");
            Assert.AreEqual(name, rank.Name, "Success : name valorisé");
            Assert.AreEqual(friendlyName, rank.FriendlyName, "Success : friendly name valorisé");
        }
    }
}