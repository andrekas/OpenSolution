using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.PartyClasses;

namespace Open.Tests.Archetypes.PartyClasses
{
    [TestClass]
    public class GeographicAddressTests : CommonTests<GeographicAddress>
    {
        protected override GeographicAddress GetRandomObj()
        {
            var p = GeographicAddress.Random();
            return p;
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
        }

        [TestCleanup]
        public override void TestCleanup()
        {
            base.TestCleanup();
        }

        [TestMethod]
        public void ConstructorTest()
        {
            var a = new GeographicAddress().GetType().BaseType;
            Assert.AreEqual(a, typeof(Address));
        }

        [TestMethod]
        public void IsNotNullTest()
        {
            Assert.IsNotNull(typeof(People));
        }

        [TestMethod]
        public void AddressLinesTest()
        {
            TestProperty(() => Obj.AddressLines, x => Obj.AddressLines = x);
        }

        [TestMethod]
        public void CityTest()
        {
            TestProperty(() => Obj.City, x => Obj.City = x);
        }

        [TestMethod]
        public void CountryTest()
        {
            TestProperty(() => Obj.Country, x => Obj.Country = x);
        }

        [TestMethod]
        public void RegionOrStateTest()
        {
            TestProperty(() => Obj.RegionOrState, x => Obj.RegionOrState = x);
        }

        [TestMethod]
        public void ZipOrPostcodeTest()
        {
            TestProperty(() => Obj.ZipOrPostcode, x => Obj.ZipOrPostcode = x);
        }      
    }
}
