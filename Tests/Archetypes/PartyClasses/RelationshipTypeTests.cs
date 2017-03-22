using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoleAndParty.Classes;

namespace RoleAndParty.Tests
{
    [TestClass]
    public class RelationshipTypeTests
    {
        private RelationshipType g;
        [TestInitialize]
        public void Init() { g = new RelationshipType(); }
        [TestCleanup]
        public void Cleanup()
        {
            g = null;
        }
        [TestMethod]
        public void ConstructorTest() { Assert.IsNotNull(g); }

        [TestMethod]
        public void NameTests()
        {
            var fakeValue = "some kind of Name";
            g.Gender = fakeValue;
            Assert.AreEqual(fakeValue, g.Gender);
            Assert.AreEqual(typeof(string), g.Gender.GetType());
        }

        [TestMethod]
        public void DescriptionTests()
        {
            var fakeValue = "some kind of Description";
            g.Description = fakeValue;
            Assert.AreEqual(fakeValue, g.Description);
            Assert.AreEqual(typeof(string), g.Description.GetType());
        }

        [TestMethod]
        public void IsNotNullTest()
        {
            Assert.IsNotNull(typeof(RelationshipTypes));
        }
    }
}
