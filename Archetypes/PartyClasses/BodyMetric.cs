using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class BodyMetric: UniqueEntity

    {
        private string partyId;
        public string PartyId
        {
            get { return SetDefault(ref partyId); }
            set { SetValue(ref partyId, value); }
        }

        public string Name { get; set; }
        public object Value { get; set; }
    }
}
