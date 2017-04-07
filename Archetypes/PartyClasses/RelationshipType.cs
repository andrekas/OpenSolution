using Open.Aids;

namespace Open.Archetypes.PartyClasses
{
    public class RelationshipType
    {
        private string name;
        private string description;

        public string Gender
        {
            get { return Str.EmptyIfNull(name); }
            set { name = value; }
        }

        public string Description
        {
            get { return Str.EmptyIfNull(description); }
            set { description = value; }
        }
        
    }
}