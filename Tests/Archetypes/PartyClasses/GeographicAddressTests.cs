using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.PartyClasses;

namespace Open.Tests.Archetypes.PartyClasses
{
    [TestClass]
    public class GeographicAddressTests
    {
        private GeographicAddress g;
        [TestInitialize]
        public void Init() { g = new GeographicAddress(); }
        [TestCleanup]
        public void Cleanup()
        {
            g = null;
        }

        [TestMethod]
        public void ConstructorTest() { Assert.IsNotNull(g); }

        [TestMethod]
        public void AddressLinesTest()
        {
            var fakeValue = "some kind of address";
            g.AddressLines = fakeValue;
            Assert.AreEqual(fakeValue, g.AddressLines);
            Assert.AreEqual(typeof(string), g.AddressLines.GetType());
        }

        [TestMethod]
        public void CityTest()
        {
            var fakeValue = "some kind of city name";
            g.City = fakeValue;
            Assert.AreEqual(fakeValue, g.City);
            Assert.AreEqual(typeof(string), g.City.GetType());
        }

        [TestMethod]
        public void CountryTest()
        {
            var fakeValue = "some kind of country name";
            g.Country = fakeValue;
            Assert.AreEqual(fakeValue, g.Country);
            Assert.AreEqual(typeof(string), g.Country.GetType());
        }

        [TestMethod]
        public void RegionOrStateTest()
        {
            var fakeValue = "some kind of region or state name";
            g.RegionOrState = fakeValue;
            Assert.AreEqual(fakeValue, g.RegionOrState);
            Assert.AreEqual(typeof(string), g.RegionOrState.GetType());
        }

        [TestMethod]
        public void ZipOrPostcodeTest()
        {
            var fakeValue = "some kind of zip code or postcode";
            g.ZipOrPostcode = fakeValue;
            Assert.AreEqual(fakeValue, g.ZipOrPostcode);
            Assert.AreEqual(typeof(string), g.ZipOrPostcode.GetType());
        }

        [TestMethod]
        public void IsNotNullTest()
        {
            Assert.IsNotNull(typeof(GeographicAddresses));
        }
    }
}
