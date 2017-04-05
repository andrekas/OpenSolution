using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class PartyAuthentications : Archetypes<PartyAuthentication>
    {
        public static PartyAuthentications Random()
        {
            var r = new PartyAuthentications();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++)
                r.Add(PartyAuthentication.Random());
            return r;

        }
    }
}