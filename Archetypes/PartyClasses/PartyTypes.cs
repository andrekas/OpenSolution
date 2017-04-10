using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class PartyTypes: Archetypes<PartyType>
    {
        public static PartyTypes Instance { get; } = new PartyTypes();

        public static PartyType Find(string id)
        {
            return Instance.Find(x => x.UniqueId == id);
        }
    }
}
