
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class Persons : Archetypes<Person>
    {
        public static Persons Instances { get; } = new Persons();

        public static Person FindPersonById(string id)
        {
            return Instances.Find(x => x.UniqueId == id);
        }
    }
}
