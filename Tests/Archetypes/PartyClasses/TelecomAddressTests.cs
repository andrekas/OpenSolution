using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.PartyClasses;


namespace Open.Tests.Archetypes.PartyClasses
{
    [TestClass]
    public class TelecomAddressTests
    {
        private TelecomAddress g;
        [TestInitialize]
        public void Init() { g = new TelecomAddress(); }
        [TestCleanup]
        public void Cleanup()
        {
            g = null;
        }

        [TestMethod]
        public void ConstructorTest() { Assert.IsNotNull(g); }


        [TestMethod]
        public void AreaCodeTests()
        {
            var fakeValue = "some kind of AreaCode";
            g.AreaCode = fakeValue;
            Assert.AreEqual(fakeValue, g.AreaCode);
            Assert.AreEqual(typeof(string), g.AreaCode.GetType());
        }
        [TestMethod]
        public void CountryCodeTests()
        {
            var fakeValue = "some kind of CountryCode";
            g.CountryCode = fakeValue;
            Assert.AreEqual(fakeValue, g.CountryCode);
            Assert.AreEqual(typeof(string), g.CountryCode.GetType());
        }
        [TestMethod]
        public void ExtensionTests()
        {
            var fakeValue = "some kind of Extension";
            g.Extension = fakeValue;
            Assert.AreEqual(fakeValue, g.Extension);
            Assert.AreEqual(typeof(string), g.Extension.GetType());
        }
        [TestMethod]
        public void NationalDirectDialingPrefixTests()
        {
            var fakeValue = "some kind of NationalDirectDialingPrefix";
            g.NationalDirectDialingPrefix = fakeValue;
            Assert.AreEqual(fakeValue, g.NationalDirectDialingPrefix);
            Assert.AreEqual(typeof(string), g.NationalDirectDialingPrefix.GetType());
        }
        [TestMethod]
        public void NumberTests()
        {
            var fakeValue = "some kind of Number";
            g.Number = fakeValue;
            Assert.AreEqual(fakeValue, g.Number);
            Assert.AreEqual(typeof(string), g.Number.GetType());
        }
        [TestMethod]
        public void PhysicalTypeTests()
        {
            var fakeValue = "some kind of PhysicalType";
            g.PhysicalType = fakeValue;
            Assert.AreEqual(fakeValue, g.PhysicalType);
            Assert.AreEqual(typeof(string), g.PhysicalType.GetType());
        }

        [TestMethod]
        public void IsNotNullTest()
        {
            Assert.IsNotNull(typeof(TelecomAddress));
        }


    }
}
