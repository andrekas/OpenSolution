using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class PartySignatures : Archetypes<PartySignature>
    {
        public static PartySignatures Random()
        {
            var x = new PartySignatures();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) x.Add(PartySignature.Random());
            return x;
        }
    }
}
