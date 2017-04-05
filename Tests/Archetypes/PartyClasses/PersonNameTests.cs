using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.PartyClasses;

namespace Open.Tests.Archetypes.PartyClasses
{

        [TestClass]
        public class PersonNameTests
        {

            private PersonName p;

            [TestInitialize]
            public void Init()
            {
                p = new PersonName();
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
                Assert.IsNotNull(typeof(People));
            }


        [TestMethod]
            public void PrefixTest()
            {
                var fakePrefix = new PersonName();
                fakePrefix.Prefix = "aa";
                p = fakePrefix;
            Assert.AreEqual(fakePrefix,p);
                Assert.AreEqual("aa", p.Prefix);
            }

            [TestMethod]
            public void GivenNameTest()
            {
                var fakeGivenName = new PersonName();
                fakeGivenName.GivenName = "aa";
                p = fakeGivenName;
                Assert.AreEqual(fakeGivenName, p);
                Assert.AreEqual("aa", p.GivenName);
            }

        [TestMethod]
        public void MiddleNameTest()
        {
            var fakePersonName = new PersonName();
            fakePersonName.MiddleName = "aa";
            p = fakePersonName;
            Assert.AreEqual(fakePersonName, p);
            Assert.AreEqual("aa", p.MiddleName);
        }

        [TestMethod]
        public void FamilyNameTest()
        {
            var fakeFamilyName = new PersonName();
            fakeFamilyName.FamilyName = "aa";
            p = fakeFamilyName;
            Assert.AreEqual(fakeFamilyName, p);
            Assert.AreEqual("aa", p.FamilyName);
        }

        [TestMethod]
        public void PrefferedNameTest()
        {
            var fakePrefferedName = new PersonName();
            fakePrefferedName.PrefferedName = "aa";
            p = fakePrefferedName;
            Assert.AreEqual(fakePrefferedName, p);
            Assert.AreEqual("aa", p.PrefferedName);
        }

        [TestMethod]
        public void SuffixTest()
        {
            var fakeSuffix = new PersonName();
            fakeSuffix.Suffix = "aa";
            p = fakeSuffix;
            Assert.AreEqual(fakeSuffix, p);
            Assert.AreEqual("aa", p.Suffix);
        }

        [TestMethod]
        public void UseTest()
        {
            var fakeUse = new PersonName();
            fakeUse.Use = "aa";
            p = fakeUse;
            Assert.AreEqual(fakeUse, p);
            Assert.AreEqual("aa", p.Use);
        }

        [TestMethod]
        public void ValidFromDateTest()
        {
            var fakeDate = new PersonName();
            fakeDate.ValidFrom = new DateTime(2015);
            p = fakeDate;
            Assert.AreEqual(fakeDate.ValidFrom, p.ValidFrom);
        }

        [TestMethod]
        public void ValidToDateTest()
        {
            var fakeDate = new PersonName();
            fakeDate.ValidTo = new DateTime(2015);
            p = fakeDate;
            Assert.AreEqual(fakeDate.ValidTo, p.ValidTo);
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



    }
}
