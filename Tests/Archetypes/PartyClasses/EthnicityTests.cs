using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.PartyClasses;

namespace Open.Tests.Archetypes.PartyClasses
{

        [TestClass]
        public class EthnicityTests
        {
            private Ethnicity e;
            [TestInitialize]
            public void Init() { e = new Ethnicity(); }
            [TestCleanup]
            public void Cleanup()
            {
                e = null;
            }

            [TestMethod]
            public void ConstructorTest() { Assert.IsNotNull(e); }

            [TestMethod]
            public void EthnicityNameTest()
            {
                var fakeValue = "some kind of ethnicity";
                e.EthnicityName = fakeValue;
                Assert.AreEqual(fakeValue, e.EthnicityName);
                Assert.AreEqual(typeof(string), e.EthnicityName.GetType());
            }

        [TestMethod]
        public void DescriptionTest()
        {
            var fakeValue = "some kind of description";
            e.Description = fakeValue;
            Assert.AreEqual(fakeValue, e.Description);
            Assert.AreEqual(typeof(string), e.Description.GetType());
        }
    }
}
