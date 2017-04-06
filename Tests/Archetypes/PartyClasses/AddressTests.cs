using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.PartyClasses;
using Open.Tests.Aids;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;

namespace Open.Tests.Archetypes.PartyClasses
{
    [TestClass]
    public class AddressTests: CommonTests<Address>
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
            Assert.AreEqual(a, typeof(BaseEntity<Party>));
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
