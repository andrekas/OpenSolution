
namespace RoleAndParty.Classes
{
    public class Persons : Archetypes<Person>
    {
        public Persons Instances { get; } = new Persons();
    }
}
