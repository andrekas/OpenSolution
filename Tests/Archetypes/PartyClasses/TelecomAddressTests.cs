using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.PartyClasses;

namespace Open.Tests.Archetypes.PartyClasses
{
    [TestClass]
    public class TelecomAddressTests : CommonTests<TelecomAddress>
    {
        protected override TelecomAddress GetRandomObj()
        {
            var p = TelecomAddress.Random();
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
            var a = new TelecomAddress().GetType().BaseType;
            Assert.AreEqual(a, typeof(Address));
        }

        [TestMethod]
        public void IsNotNullTest()
        {
            Assert.IsNotNull(typeof(People));
        }

        [TestMethod]
        public void AreaCodeTests()
        {
            TestProperty(() => Obj.AreaCode, x => Obj.AreaCode = x);
        }

        [TestMethod]
        public void CountryCodeTests()
        {
            TestProperty(() => Obj.CountryCode, x => Obj.CountryCode = x);
        }

        [TestMethod]
        public void ExtensionTests()
        {
            TestProperty(() => Obj.Extension, x => Obj.Extension = x);
        }

        [TestMethod]
        public void NationalDirectDialingPrefixTests()
        {
            TestProperty(() => Obj.NationalDirectDialingPrefix, x => Obj.NationalDirectDialingPrefix = x);
        }

        [TestMethod]
        public void NumberTests()
        {
            TestProperty(() => Obj.Number, x => Obj.Number = x);
        }

        [TestMethod]
        public void PhysicalTypeTests()
        {
            TestProperty(() => Obj.PhysicalType, x => Obj.PhysicalType = x);
        }     
    }
}
