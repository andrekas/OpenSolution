using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoleAndParty.Classes;

namespace XPProject.Tests
{
    [TestClass]
    public class OrganisationTypeTests
    {
        private OrganisationType g;
        [TestInitialize]
        public void Init() { g = new OrganisationType(); }
        [TestCleanup]
        public void Cleanup()
        {
            g = null;
        }
        [TestMethod]
        public void ConstructorTest() { Assert.IsNotNull(g); }

        [TestMethod]
        public void SyperTypeTests()
        {
            var fakeValue = "some kind of sypertype";
            g.SyperType = fakeValue;
            Assert.AreEqual(fakeValue, g.SyperType);
            Assert.AreEqual(typeof(string), g.SyperType.GetType());
        }
    }
}
