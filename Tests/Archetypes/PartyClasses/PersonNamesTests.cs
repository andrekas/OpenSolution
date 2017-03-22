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
    public class PersonNamesTests
    {
        [TestMethod]
        public void Sampletest()
        {
            var fakePersonNameOne = new PersonName();
            fakePersonNameOne.GivenName = "fakeGivenNameOne";
            var fakePersonNameTwo = new PersonName();
            fakePersonNameTwo.GivenName = "fakeGivenNameTwo";
            PersonNames.Instances.Add(fakePersonNameOne);
            PersonNames.Instances.Add(fakePersonNameTwo);
            Assert.AreEqual(2, PersonNames.Instances.Count);
            var personName = PersonNames.GetGivenName("fakeGivenNameTwo");
            Assert.AreEqual(fakePersonNameTwo, personName);

        }
    }
}
