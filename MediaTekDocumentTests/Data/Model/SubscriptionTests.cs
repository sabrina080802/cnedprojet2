using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocument.Data.Model.Tests
{
    [TestClass()]
    public class SubscriptionTests
    {

        private const string id = "10001";
        private static readonly DateTime dateFinAbonnement = DateTime.Now;
        private const string idRevue = "50005";

        private static readonly Subscription subscription = new Subscription(id, dateFinAbonnement, idRevue);

        [TestMethod()]
        public void SubscriptionTest()
        {
            Assert.AreEqual(id, subscription.Id, "Success : id valorisé");
            Assert.AreEqual(dateFinAbonnement, subscription.DateFinAbonnement, "Success : Date Fin Abonnement valorisé");
            Assert.AreEqual(idRevue, subscription.IdRevue, "Success : IdRevue valorisé");
        }
    }
}