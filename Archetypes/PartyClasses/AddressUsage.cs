using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class AddressUsage: UniqueEntity
    {
        private string partyId;

        public string PartyId
        {
            get { return SetDefault(ref partyId); }
            set { SetValue(ref partyId, value); }
        }
        private string addressId;

        public string AddressId
        {
            get { return SetDefault(ref addressId); }
            set { SetValue(ref addressId, value); }
        }
        public Address Address
        {
            get { return Addresses.Instance.Find(x=>x.UniqueId == AddressId); }
        }

    }
}
