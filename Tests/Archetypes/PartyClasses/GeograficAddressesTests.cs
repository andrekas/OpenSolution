using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.PartyClasses;

namespace Open.Tests.Archetypes.PartyClasses
{
    [TestClass]
    public class GeograficAddressesTests
    {
        private GeographicAddresses g;

        [TestInitialize]
        public void Init()
        {
            g = new GeographicAddresses();
        }

        [TestCleanup]
        public void Cleanup()
        {
            g = null;
        }

        [TestMethod]
        public void ConstructorTest()
        {

            Assert.IsNotNull(g);
        }
        [TestMethod]
        public void GeograficAddressesInstancesTest()
        {
            var fakeGeograficAddressOne = new GeographicAddress();
            //fakeGeograficAddressOne.AddressLines = "fakeGeograficAddressOne";
            var fakeGeograficAddressTwo = new GeographicAddress();
            //fakeGeograficAddressOne.AddressLines = "fakeGeograficAddressTwo";
            GeographicAddresses.Instances.Add(fakeGeograficAddressOne);
            GeographicAddresses.Instances.Add(fakeGeograficAddressTwo);
            Assert.AreEqual(2, GeographicAddresses.Instances.Count);
        }
       
        [TestMethod]
        public void AddressLinesTest()
        {
            var fakeGeograficAddressOne = new GeographicAddress();
            fakeGeograficAddressOne.AddressLines = "fakeGeograficAddressLinesOne";
            var fakeGeograficAddressTwo = new GeographicAddress();
            fakeGeograficAddressOne.AddressLines = "fakeGeograficAddressLinesTwo";
            var addressLines = GeographicAddresses.GetAddressLines("fakeGeograficAddressLinesTwo");
            Assert.AreEqual(fakeGeograficAddressTwo, addressLines);

        }

        //[TestMethod]
        //public void GeograficAddressesTest()
        //{
        //    var fakeGeograficAddressOne = new GeographicAddress();
        //    fakeGeograficAddressOne.AddressLines = "fakeGeograficAddressOne";
        //    var fakeGeograficAddressTwo = new GeographicAddress();
        //    fakeGeograficAddressOne.AddressLines = "fakeGeograficAddressTwo";
        //    GeographicAddresses.Instances.Add(fakeGeograficAddressOne);
        //    GeographicAddresses.Instances.Add(fakeGeograficAddressTwo);
        //    Assert.AreEqual(2, GeographicAddresses.Instances.Count);
        //    var addressLines = GeographicAddresses.GetAddressLines("fakeGeograficAddressLinesTwo");
        //    Assert.AreEqual(fakeGeograficAddressTwo, addressLines);
        //}
    }
}
