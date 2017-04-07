using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.PartyClasses;


namespace Open.Tests.Archetypes.PartyClasses
{
    [TestClass]
    public class ISOGenderTests: ClassTests<ISOGender>
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.AreEqual(4, Enum.GetNames(typeof(ISOGender)).Length);
        }

        [TestMethod]
        public void MaleTest()
        {
            Assert.AreEqual(1, (int) ISOGender.Male);
        }

        [TestMethod]
        public void NotApplicableTest()
        {
            Assert.AreEqual(9, (int) ISOGender.NotSpecified);
        }

        [TestMethod]
        public void FemaleTest()
        {
            Assert.AreEqual(2, (int) ISOGender.Female);
        }

        [TestMethod]
        public void NotKnownTest()
        {
            Assert.AreEqual(0, (int) ISOGender.NotKnown);
        }
    }
}