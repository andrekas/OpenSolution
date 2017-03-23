using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.PartyClasses;

namespace Open.Tests.Archetypes.PartyClasses
{    
    [TestClass]
    public class EmailAddressTests
    {
        private EmailAddress g;
        [TestInitialize]
        public void Init() { g = new EmailAddress(); }
        [TestCleanup]
        public void Cleanup()
        {
            g = null;
        }

        [TestMethod]
        public void ConstructorTest() { Assert.IsNotNull(g); }


        [TestMethod]
        public void EmailTests()
        {
            var fakeValue = "some kind of email";
            g.Email = fakeValue;
            Assert.AreEqual(fakeValue, g.Email);
            Assert.AreEqual(typeof(string), g.Email.GetType());
        }

        [TestMethod]
        public void IsNotNullTest()
        {
            Assert.IsNotNull(typeof(EmailAddresses));
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
    }
}
