using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class PartyType: BaseType<PartyType>
    {
        public override PartyType Type => PartyTypes.Find(TypeId);
        public string Name { get; set; } 
        public static PartyType Person
        {
            get
            {
                var p = new PartyType
                {
                    Name = "Person",
                    UniqueId = "Person",
                    TypeId = string.Empty
                };
                return p;
            }
        }
    }
}
