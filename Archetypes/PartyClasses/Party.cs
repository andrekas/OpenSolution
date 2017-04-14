using Open.Archetypes.BaseClasses;
namespace Open.Archetypes.PartyClasses
{
    public abstract class Party: BaseEntity<PartyType>
    {
        private string description;
        public AddressUsages Addresses => AddressUsages.GetPersonAddresses(UniqueId);
        public abstract string GetName();
        public string Description
        {
            get { return SetDefault(ref description); }
            set { SetValue(ref description, value); }
        }

        public override PartyType Type => PartyTypes.Find(TypeId);
    }
}
