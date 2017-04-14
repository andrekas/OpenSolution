using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Archetypes.PartyClasses
{
    public class PartyEthnicities: Archetypes<PartyEthnicity>
    {
        public static PartyEthnicities Instance { get; } = new PartyEthnicities();
        public static PartyEthnicities GetPersonEthnicities(string personId) {
            var e = new PartyEthnicities();
            var l = Instance.FindAll(o=>o.PartyId == personId);
            e.AddRange(l);
            return e;
        }
    }
}
