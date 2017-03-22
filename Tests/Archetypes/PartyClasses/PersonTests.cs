using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoleAndParty.Classes;

namespace XPProject.Tests
{
    [TestClass]
    public class PersonTests
    {

        private Person p;

        [TestInitialize]
        public void Init()
        {
            p = new Person();
        }

        [TestCleanup]
        public void Cleanup()
        {
            p = null;
        }
        
        [TestMethod]
        public void ConstructorTest()
        {

            Assert.IsNotNull(p);
        }
        
        [TestMethod]
        public void NameTests()
        {
            var fakeValue = "some kind of Name";

            p.Name = fakeValue;
            Assert.AreEqual(fakeValue, p.Name);
            Assert.AreEqual(typeof(string), p.Name.GetType());
        }


        //[TestMethod]
        //public void GenderTests()
        //{

        //    var fakeGender = new ISOGender();
        //    p.Gender = fakeGender;
        //    Assert.AreEqual(fakeGender, p.PersonName);

        ////var fakeValue = "some kind of Gender";

        ////p.Gender = fakeValue;
        ////Assert.AreEqual(fakeValue, p.Gender);
        ////Assert.AreEqual(typeof(string), p.Gender.GetType());
        // }

      

        [TestMethod]
        public void DateTimeTests()
        {
            
        }

        [TestMethod]
        public void IsNotNullTest()
        {
            Assert.IsNotNull(typeof(Persons));
        }

        [TestMethod]
        public void PrefixTest()
        {
            var fakePrefix = new PersonName();
            fakePrefix.Prefix = "aa";
            p.PersonName = fakePrefix;
            Assert.AreEqual(fakePrefix, p.PersonName);
            Assert.AreEqual("aa", p.PersonName.Prefix);
        }

        [TestMethod]
        public void GivenNameTest()
        {
            var fakeGivenName = new PersonName();
            fakeGivenName.GivenName = "aa";
            p.PersonName = fakeGivenName;
            Assert.AreEqual(fakeGivenName, p.PersonName);
            Assert.AreEqual("aa", p.PersonName.GivenName);
        }

        [TestMethod]
        public void MiddleNameTest()
        {
            var fakePersonName = new PersonName();
            fakePersonName.MiddleName = "aa";
            p.PersonName = fakePersonName;
            Assert.AreEqual(fakePersonName, p.PersonName);
            Assert.AreEqual("aa", p.PersonName.MiddleName);
        }

        [TestMethod]
        public void FamilyNameTest()
        {
            var fakeFamilyName = new PersonName();
            fakeFamilyName.FamilyName = "aa";
            p.PersonName = fakeFamilyName;
            Assert.AreEqual(fakeFamilyName, p.PersonName);
            Assert.AreEqual("aa", p.PersonName.FamilyName);
        }

        [TestMethod]
        public void PrefferedNameTest()
        {
            var fakePrefferedName = new PersonName();
            fakePrefferedName.PrefferedName = "aa";
            p.PersonName = fakePrefferedName;
            Assert.AreEqual(fakePrefferedName, p.PersonName);
            Assert.AreEqual("aa", p.PersonName.PrefferedName);
        }

        [TestMethod]
        public void SuffixTest()
        {
            var fakeSuffix = new PersonName();
            fakeSuffix.Suffix = "aa";
            p.PersonName = fakeSuffix;
            Assert.AreEqual(fakeSuffix, p.PersonName);
            Assert.AreEqual("aa", p.PersonName.Suffix);
        }

        [TestMethod]
        public void UseTest()
        {
            var fakeUse = new PersonName();
            fakeUse.Use = "aa";
            p.PersonName = fakeUse;
            Assert.AreEqual(fakeUse, p.PersonName);
            Assert.AreEqual("aa", p.PersonName.Use);
        }

        [TestMethod]
        public void ValidFromDateTest()
        {
            var fakeDate = new PersonName();
            fakeDate.ValidFrom = new DateTime(2015);
            p.PersonName = fakeDate;
            Assert.AreEqual(fakeDate.ValidFrom, p.PersonName.ValidFrom);
        }

        //[TestMethod]
        //public void ValidToDateTest()
        //{
        //    var fakeDate = new PersonName();
        //    fakeDate.ValidFrom = new DateTime(1582, 10, 5);
        //    p.PersonName = fakeDate;
        //    Assert.AreEqual(fakeDate, p.PersonName);
        //    Assert.AreEqual(fakeDate, p.PersonName.ValidTo);
        //}

        [TestMethod]
        public void EthnisityNameTest()
        {
            var fakeEthnicityName = new Ethnicity();
            fakeEthnicityName.Name = "aa";
            p.Ethnicity = fakeEthnicityName;
            Assert.AreEqual(fakeEthnicityName, p.Ethnicity);
            Assert.AreEqual("aa", p.Ethnicity.Name);
        }


        [TestMethod]
        public void EthnisityDescriptionTest()
        {
            var fakeEthnicityDescription = new Ethnicity();
            fakeEthnicityDescription.Description = "aa";
            p.Ethnicity = fakeEthnicityDescription;
            Assert.AreEqual(fakeEthnicityDescription, p.Ethnicity);
            Assert.AreEqual("aa", p.Ethnicity.Description);
        }


    }
}
