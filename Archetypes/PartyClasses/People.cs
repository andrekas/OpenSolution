
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class People : Archetypes<Person>
    {
        public static People Instances { get; } = new People();

        public static Person FindPersonById(string id)
        {
            return Instances.Find(x => x.UniqueId == id);
        }
    }
}
