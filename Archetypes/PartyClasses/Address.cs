using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class Address: BaseEntity<Party>

    {
        private DateTime validFrom;
        private DateTime validTo;
        private GeographicAddress geographicAddress;
        private TelecomAddress telecomAddress;
        private WebpageAddress webpageAddress;
        private EmailAddress emailAddress;

        public Address ContactAddress
        {
            get { return Addresses.FindPersonAddressById(UniqueId); }
        }

        public GeographicAddress GeographicAddress
        {
            get { return SetDefault(ref geographicAddress); }
            set { SetValue(ref geographicAddress, value); }
        }

        public TelecomAddress TelecomAddress
        {
            get { return SetDefault(ref telecomAddress); }
            set { SetValue(ref telecomAddress, value); }
        }

        public WebpageAddress WebpageAddress
        {
            get { return SetDefault(ref webpageAddress); }
            set { SetValue(ref webpageAddress, value); }
        }

        public EmailAddress EmailAddress
        {
            get { return SetDefault(ref emailAddress); }
            set { SetValue(ref emailAddress, value); }
        }

        public DateTime ValidFrom
        {
            get { return SetDefault(ref validFrom); }
            set { SetValue(ref validFrom, value); }
        }

        public DateTime ValidTo
        {
            get { return SetDefault(ref validTo); }
            set { SetValue(ref validTo, value); }
        }
        public override Party Type { get; }
    }
}
