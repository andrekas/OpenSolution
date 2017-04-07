using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.PartyClasses;

namespace Open.Tests.Archetypes.PartyClasses
{

    [TestClass]
    public class PersonNameTests : CommonTests<PersonName>

    {
        protected override PersonName GetRandomObj()
        {
            var p = PersonName.Random();
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
            var a = new PersonName().GetType().BaseType;
            Assert.AreEqual(a, typeof(TemporalEntity));
        }
        [TestMethod]
        public void IsNotNullTest()
        {
            Assert.IsNotNull(typeof(People));
        }

        [TestMethod]
        public void PrefixTest()
        {
            TestProperty(() => Obj.Prefix, x => Obj.Prefix = x);
        }

        [TestMethod]
        public void GivenNameTest()
        {
            TestProperty(() => Obj.GivenName, x => Obj.GivenName = x);
        }

        [TestMethod]
        public void MiddleNameTests()
        {
            var Obj = new PersonName();
            TestProperty(() => Obj.MiddleName, x => Obj.MiddleName = x);

        }
        [TestMethod]
        public void FamilyNameTest()
        {
            var Obj = new PersonName();
            TestProperty(() => Obj.FamilyName, x => Obj.FamilyName = x);

        }
        [TestMethod]
        public void PrefferedNameTest()
        {
            TestProperty(() => Obj.PrefferedName, x => Obj.PrefferedName = x);

        }

        [TestMethod]
        public void SuffixTest()
        {
            var Obj = new PersonName();
            TestProperty(() => Obj.Suffix, x => Obj.Suffix = x);

        }

        [TestMethod]
        public void UseTest()
        {
            TestProperty(() => Obj.Use, x => Obj.Use = x);

        }

        [TestMethod]
        public void ValidFromTest()
        {
            
            TestProperty(() => Obj.Valid.From, x => Obj.Valid.From = x);

        }

        [TestMethod]
        public void ValidToTest()
        {
            TestProperty(() => Obj.Valid.To, x => Obj.Valid.To = x);

        }




        //    [TestMethod]
        //public void PrefixTest()
        //{
        //    var fakePrefix = new PersonName();
        //    fakePrefix.Prefix = "aa";
        //    p = fakePrefix;
        //    Assert.AreEqual(fakePrefix, p);
        //    Assert.AreEqual("aa", p.Prefix);
        //}

        //[TestMethod]
        //public void GivenNameTest()
        //{
        //    var fakeGivenName = new PersonName();
        //    fakeGivenName.GivenName = "aa";
        //    p = fakeGivenName;
        //    Assert.AreEqual(fakeGivenName, p);
        //    Assert.AreEqual("aa", p.GivenName);
        //}

        //[TestMethod]
        //public void MiddleNameTest()
        //{
        //    var fakePersonName = new PersonName();
        //    fakePersonName.MiddleName = "aa";
        //    p = fakePersonName;
        //    Assert.AreEqual(fakePersonName, p);
        //    Assert.AreEqual("aa", p.MiddleName);
        //}

        //[TestMethod]
        //public void FamilyNameTest()
        //{
        //    var fakeFamilyName = new PersonName();
        //    fakeFamilyName.FamilyName = "aa";
        //    p = fakeFamilyName;
        //    Assert.AreEqual(fakeFamilyName, p);
        //    Assert.AreEqual("aa", p.FamilyName);
        //}

        //[TestMethod]
        //public void PrefferedNameTest()
        //{
        //    var fakePrefferedName = new PersonName();
        //    fakePrefferedName.PrefferedName = "aa";
        //    p = fakePrefferedName;
        //    Assert.AreEqual(fakePrefferedName, p);
        //    Assert.AreEqual("aa", p.PrefferedName);
        //}

        //[TestMethod]
        //public void SuffixTest()
        //{
        //    var fakeSuffix = new PersonName();
        //    fakeSuffix.Suffix = "aa";
        //    p = fakeSuffix;
        //    Assert.AreEqual(fakeSuffix, p);
        //    Assert.AreEqual("aa", p.Suffix);
        //}

        //[TestMethod]
        //public void UseTest()
        //{
        //    var fakeUse = new PersonName();
        //    fakeUse.Use = "aa";
        //    p = fakeUse;
        //    Assert.AreEqual(fakeUse, p);
        //    Assert.AreEqual("aa", p.Use);
        //}

        //[TestMethod]
        //public void ValidFromDateTest()
        //{
        //    var fakeDate = new PersonName();
        //    fakeDate.ValidFrom = new DateTime(2015);
        //    p = fakeDate;
        //    Assert.AreEqual(fakeDate.ValidFrom, p.ValidFrom);
        //}

        //[TestMethod]
        //public void ValidToDateTest()
        //{
        //    var fakeDate = new PersonName();
        //    fakeDate.ValidTo = new DateTime(2015);
        //    p = fakeDate;
        //    Assert.AreEqual(fakeDate.ValidTo, p.ValidTo);
        //}


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
