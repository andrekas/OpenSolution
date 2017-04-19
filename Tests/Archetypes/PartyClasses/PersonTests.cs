using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.PartyClasses;

namespace Open.Tests.Archetypes.PartyClasses
{
    [TestClass]
    public class PersonTests: CommonTests<Person>
    {
        protected override Person GetRandomObj()
        {
            return Person.Random();
        }
        [TestMethod] public void TypeTest() {
            Assert.AreEqual(PartyType.Person, Obj.Type);
        }
        [TestMethod] public void GetNameTest() {
            var n = PersonName.Random();
            n.PersonId = Obj.UniqueId;
            PersonNames.Instance.Add(n);
            Assert.AreEqual(n.ToString(), Obj.GetName());

        }
        //[TestMethod]
        //public void GetEthnisityTest()
        //{
        //    var n = Ethnicity.Random();
        //    n.EthnicityName = Obj.UniqueId;
        //    Ethnicities.Instance.Add(n);
        //    Assert.AreEqual(n.ToString(), Obj.GetP());

        //}
    }
}
