using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.PartyClasses;

namespace Open.Tests.Archetypes.PartyClasses
{    
    [TestClass]
    public class EmailAddressTests : CommonTests<EmailAddress>
    {
        protected override EmailAddress GetRandomObj()
        {
            var p = EmailAddress.Random();
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
            var a = new EmailAddress().GetType().BaseType;
            Assert.AreEqual(a, typeof(Address));
        }
        [TestMethod]
        public void IsNotNullTest()
        {
            Assert.IsNotNull(typeof(People));
        }
        [TestMethod]
        public void EmailTest()
        {
            TestProperty(() => Obj.Email, x => Obj.Email = x);
        }
        //public TestContext TestContext
        //{
        //    get
        //    {
        //        return testContextInstance;
        //    }
        //    set
        //    {
        //        testContextInstance = value;
        //    }
        //}
    }
}
