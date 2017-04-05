using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.PartyClasses;


namespace Open.Tests.Archetypes.PartyClasses
{
    [TestClass]
    public class PersonNamesTests : CommonTests<PersonNames>
    {
        private PersonNames p;

        [TestInitialize]
        public void Init()
        {
            p = new PersonNames();
            PersonNames.Instances.Clear();
        }

        [TestCleanup]
        public void Cleanup()
        {
            p = null;
        }

        //[TestMethod]
        //public void ConstructorTest()
        //{

        //    Assert.IsNotNull(p);
        //}

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.AreEqual(Obj.GetType().BaseType, typeof(PersonName));
            Assert.IsInstanceOfType(Obj, typeof(IList<string>));
        }


        protected override PersonNames GetRandomObj()
        {
            return PersonNames.Random();
        }
        [TestMethod]
        public void InstanceTest()
        {
            TestSingleton(() => PersonNames.Instances);
        }

        [TestMethod]
        public void Nametest()
        {
            var fakePersonNameOne = new PersonName();
            fakePersonNameOne.GivenName = "fakeGivenNameOne";
            var fakePersonNameTwo = new PersonName();
            fakePersonNameTwo.GivenName = "fakeGivenNameTwo";
            PersonNames.Instances.Add(fakePersonNameOne);
            PersonNames.Instances.Add(fakePersonNameTwo);
            Assert.AreEqual(2, PersonNames.Instances.Count);
            //var personName = PersonNames.GetName("fakeGivenNameTwo");
            //Assert.AreEqual(fakePersonNameTwo, personName);
        }


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






