using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoleAndParty.Classes;

namespace XPProject.Tests
{
    [TestClass]
    public class ISOGenderTests
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