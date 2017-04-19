using Open.Archetypes.PartyClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;

namespace Open.Tests.Archetypes.PartyClasses
{
    [TestClass]
    public class AddressTests : CommonTests<Address>
    {
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
            var a = new Address().GetType().BaseType;
            Assert.AreEqual(a, typeof(UniqueEntity));
        }

        [TestMethod]
        public void IsNotNullTest()
        {
            Assert.IsNotNull(typeof(Addresses));
        }

        protected override Address GetRandomObj()
        {
            return Address.Random();
        }
    }
}
