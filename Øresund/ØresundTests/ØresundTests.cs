using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Øresund;

namespace ØresundTests
{
    [TestClass]
    public class ØresundTests
    {
        [TestMethod]
        public void BilMedBrobizz()
        {
            ØresundsBil bil = new ØresundsBil("AB12345", new DateTime(), true);

            Assert.AreEqual(161, bil.Pris());
        }

        [TestMethod]
        public void BilUdenBrobizz()
        {
            ØresundsBil bil = new ØresundsBil("AB12345", new DateTime(), false);

            Assert.AreEqual(410, bil.Pris());
        }

        [TestMethod]
        public void BilKorrektType()
        {
            ØresundsBil bil = new ØresundsBil("AB12345", new DateTime(), false);

            Assert.AreEqual("Øresund Bil", bil.Køretøj());
        }

        [TestMethod]
        public void MCMedBrobizz()
        {
            ØresundsMC motorcykel = new ØresundsMC("AB12345", new DateTime(), true);

            Assert.AreEqual(73, motorcykel.Pris());
        }

        [TestMethod]
        public void MCUdenBrobizz()
        {
            ØresundsMC motorcykel = new ØresundsMC("AB12345", new DateTime(), false);

            Assert.AreEqual(210, motorcykel.Pris());
        }

        [TestMethod]
        public void MCKorrektType()
        {
            ØresundsMC motorcykel = new ØresundsMC("AB12345", new DateTime(), false);

            Assert.AreEqual("Øresund MC", motorcykel.Køretøj());
        }
    }
}
