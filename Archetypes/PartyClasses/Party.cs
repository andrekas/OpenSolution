using Open.Archetypes.BaseClasses;
namespace Open.Archetypes.PartyClasses
{
    public class Party: UniqueEntity
    {
        public Addresses Addresses
        {
            get { return Addresses.GetPersonAddresses(UniqueId); }
        }
    }
}
