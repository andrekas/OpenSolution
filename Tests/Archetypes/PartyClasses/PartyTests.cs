﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.PartyClasses;
namespace Open.Tests.Archetypes.PartyClasses {
    [TestClass] public class PartyTests : ClassTests<Party> {
        [TestMethod] public void ConstructorTest() {
            var a = typeof(Party).BaseType;
            Assert.AreEqual(a, typeof(BaseEntity<PartyType>));
        }
    }
}