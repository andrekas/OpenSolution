using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.PartyClasses;

namespace Open.Tests.Archetypes.PartyClasses
{
    [TestClass]
    public class BodyMetricTests : CommonTests<BodyMetric>
    {
        protected override BodyMetric GetRandomObj()
        {
            var p = BodyMetric.Random();
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
            var a = new BodyMetric().GetType().BaseType;
            Assert.AreEqual(a, typeof(UniqueEntity));
        }
        [TestMethod]
        public void IsNotNullTest()
        {
            Assert.IsNotNull(typeof(People));
        }
        [TestMethod]
        public void PartyIdTest()
        {
            TestProperty(() => Obj.PartyId, x => Obj.PartyId = x);
        }
        [TestMethod]
        public void NameTest()
        {
            TestProperty(() => Obj.Name, x => Obj.Name = x);
        }
        [TestMethod]
        public void PrefixTest()
        {
            TestProperty(() => Obj.Value, x => Obj.Value = x);
        }
    }
}
