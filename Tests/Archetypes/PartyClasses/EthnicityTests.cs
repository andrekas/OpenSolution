using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.PartyClasses;

namespace Open.Tests.Archetypes.PartyClasses
{
        [TestClass]
        public class EthnicityTests : CommonTests<Ethnicity>
    {
        protected override Ethnicity GetRandomObj()
        {
            var p = Ethnicity.Random();
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
            var a = new Ethnicity().GetType().BaseType;
            Assert.AreEqual(a, typeof(UniqueEntity));
        }
        [TestMethod]
        public void IsNotNullTest()
        {
            Assert.IsNotNull(typeof(People));
        }

        [TestMethod]
            public void EthnicityNameTest()
        {
            TestProperty(() => Obj.EthnicityName, x => Obj.EthnicityName = x);
        }

        [TestMethod]
        public void DescriptionTest()
        {
            TestProperty(() => Obj.Description, x => Obj.Description = x);
        }
    }
}
