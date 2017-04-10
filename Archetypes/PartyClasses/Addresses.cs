using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class Addresses : Archetypes<Address>
    {
        public static Addresses Instance { get; } = new Addresses();


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
