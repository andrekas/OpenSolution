using Open.Archetypes.BaseClasses;
namespace Open.Archetypes.PartyClasses
{
    public class Party: BaseEntity<PartyType>
    {
        private string personName;
        private string description;
        public AddressUsages Addresses => AddressUsages.GetPersonAddresses(UniqueId);

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

        public override PartyType Type => PartyTypes.Find(TypeId);
    }
}
