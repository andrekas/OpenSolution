using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class Addresses : Archetypes<Address>
    {
        public static Addresses Instance { get; } = new Addresses();

        public static Addresses GetPersonAddresses(string uniqueId)
        {
            var r = new Addresses();
            var l = Instance.FindAll(x => x.PartyId == uniqueId);
            r.AddRange(l);
            return r;
        }

        //public static Address FindPersonAddressById(string id)
        //{
        //    return Instances.Find(x => x.UniqueId == id);
        //}

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
