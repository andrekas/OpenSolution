using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.PartyClasses;


namespace Open.Tests.Archetypes.PartyClasses
{
    [TestClass]
    public class PersonNamesTests : CommonTests<PersonNames>
    {

        //[TestInitialize]
        //public void Init()
        //{
        //    p = new PersonNames();
        //    PersonNames.Instance.Clear();
        //}

        //[TestCleanup]
        //public void Cleanup()
        //{
        //    p = null;
        //}

        ////[TestMethod]
        ////public void ConstructorTest()
        ////{

        ////    Assert.IsNotNull(p);
        ////}

        [TestMethod]
        public void GetPersonNamesTest()
        {
            var s = GetRandom.String();
            Assert.AreEqual(0, PersonNames.GetPersonNames(s).Count);
            var l = PersonNames.Random();
            foreach (var e in l) e.PersonId = s;
            PersonNames.Instance.AddRange(l);
            PersonNames.Instance.AddRange(PersonNames.Random());
            Assert.AreEqual(l.Count, PersonNames.GetPersonNames(s).Count);
        }
        //[TestMethod]
        //public void FindNameTest()
        //{
        //    var s = GetRandom.String();
        //    Assert.IsNull(PersonNames.Find(s));
        //    var l = PersonName.Random();
        //    l.PersonId = s;
        //    PersonNames.Instance.Add(l);
        //    PersonNames.Instance.AddRange(PersonNames.Random());
        //    Assert.AreEqual(l, PersonNames.Find(s));
        //}


        protected override PersonNames GetRandomObj()
        {
            return PersonNames.Random();
        }
        [TestMethod]
        public void InstanceTest()
        {
            TestSingleton(() => PersonNames.Instance);
        }

        //[TestMethod]
        //public void Nametest()
        //{
        //    var fakePersonNameOne = new PersonName();
        //    fakePersonNameOne.GivenName = "fakeGivenNameOne";
        //    var fakePersonNameTwo = new PersonName();
        //    fakePersonNameTwo.GivenName = "fakeGivenNameTwo";
        //    PersonNames.Instances.Add(fakePersonNameOne);
        //    PersonNames.Instances.Add(fakePersonNameTwo);
        //    Assert.AreEqual(2, PersonNames.Instances.Count);
        //    //var personName = PersonNames.GetName("fakeGivenNameTwo");
        //    //Assert.AreEqual(fakePersonNameTwo, personName);
        //}


        //[TestMethod]
        //public void PrefixTest()
        //{
        //    var fakePersonNameOne = new PersonName();
        //    fakePersonNameOne.Prefix = "fakePrefixOne";
        //    var fakePersonNameTwo = new PersonName();
        //    fakePersonNameTwo.Prefix = "fakePrefixTwo";
        //    PersonNames.Instances.Add(fakePersonNameOne);
        //    PersonNames.Instances.Add(fakePersonNameTwo);
        //    Assert.AreEqual(2, PersonNames.Instances.Count);
        //    var personName = PersonNames.GetPrefix("fakePrefixTwo");
        //    Assert.AreEqual(fakePersonNameTwo, personName);
        //}
    }
}






