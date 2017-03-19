
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class Persons : Archetypes<Person>
    {
        public Persons Instances { get; } = new Persons();
    }
}
