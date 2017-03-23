using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class TelecomAddresses : Archetypes<TelecomAddress>
    {
        public TelecomAddresses Instances { get; } = new TelecomAddresses();
    }
}
