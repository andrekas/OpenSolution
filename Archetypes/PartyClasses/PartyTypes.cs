using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class PartyTypes: Archetypes<PartyType>
    {
        public static PartyTypes Instance { get; } = new PartyTypes();

        public static PartyType Find(string id)
        {
            return Instance.Find(x => x.UniqueId == id);
        }
    }
}
