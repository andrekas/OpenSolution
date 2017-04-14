using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class PartyType: BaseType<PartyType>
    {
        private string name;
        public override PartyType Type => PartyTypes.Find(TypeId);
        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }
        public static PartyType Person { get; } = new PartyType
        {
            Name = "Person",
            UniqueId = "Person",
            TypeId = string.Empty
        };

    }
}
