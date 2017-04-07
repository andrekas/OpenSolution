using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class PersonNames: Archetypes<PersonName>
    {
        public static PersonNames Instance { get; } = new PersonNames();

        public static PersonNames GetPersonNames(string uniqueId)
        {
            var r = new PersonNames();
            var l = Instance.FindAll(x => x.PersonId == uniqueId);
            r.AddRange(l);
            return r;
        }
        
        public static PersonNames Random()
        {
            var e = new PersonNames();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++)
                e.Add(PersonName.Random());
            return e;
        }

    }
}
