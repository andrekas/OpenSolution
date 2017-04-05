
using Open.Aids;
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
        public static People Random()
        {
            var e = new People();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++)
                e.Add(Person.Random());
            return e;
        }
}
}
