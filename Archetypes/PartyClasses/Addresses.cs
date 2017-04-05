using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    class Addresses : Archetypes<Address>
    {
        public static Addresses Instances { get; } = new Addresses();

        public static Address FindPersonAddressById(string id)
        {
            return Instances.Find(x => x.UniqueId == id);
        }

        public static Addresses Random()
        {
            var e = new Addresses();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++)
                e.Add(Address.Random());
            return e;
        }
    }
}
