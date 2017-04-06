using Open.Archetypes.BaseClasses;
namespace Open.Archetypes.PartyClasses
{
    public class Party: UniqueEntity
    {
        private string personName;
        private string description;
        public Addresses Addresses
        {
            get { return Addresses.GetPersonAddresses(UniqueId); }
        }

        public string PersonName
        {
            get { return SetDefault(ref personName); }
            set { SetValue(ref personName, value); }
        }

        public string Description
        {
            get { return SetDefault(ref description); }
            set { SetValue(ref description, value); }
        }
    }
}
