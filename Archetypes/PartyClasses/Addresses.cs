using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    class Addresses: Archetypes<Address>
    {
        public static Addresses Instances { get; } = new Addresses();
        public static Address FindPersonAddressById(string id)
        {
            return Instances.Find(x => x.UniqueId == id);
        }
    }
}
