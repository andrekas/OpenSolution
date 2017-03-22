using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class GeographicAddresses : Archetypes<GeographicAddress>
    {
        public GeographicAddresses Instances { get; } = new GeographicAddresses();
    }
}
