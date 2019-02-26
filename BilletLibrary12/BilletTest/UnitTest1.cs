using BilletLibrary12;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BilPrisMetodeTest()
        {
            var bil = new Bil();

            decimal pris = bil.Pris(true);

            Assert.AreEqual(237.5, pris);
        }

        [TestMethod]
        public void BilK�ret�jMetodeTest()
        {
            var bil = new Bil();

            string k�ret�j = bil.K�ret�j();

            Assert.AreEqual("Bil", k�ret�j);
        }

        [TestMethod]
        public void MCPrisMetodeTest()
        {
            var mc = new MC();

            decimal pris = mc.Pris(false);

            Assert.AreEqual(125, pris);
        }

        [TestMethod]
        public void MCK�ret�jMetodeTest()
        {
            var mc = new MC();

            string k�ret�j = mc.K�ret�j();

            Assert.AreEqual("MC", k�ret�j);
        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void NummerpladeErForMangeNummerer()
        //{
        //    var bil = new Bil();

        //    string nummerplade = bil.Nummerplade();

        //    Assert.Fail();
        //}



    }
}
