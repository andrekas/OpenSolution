using Open.Archetypes.BaseClasses;


namespace Open.Archetypes.PartyClasses
{
    public class PartyEthnicity : UniqueEntity
    {
        private string partyId;

        public string PartyId
        {
            get { return SetDefault(ref partyId); }
            set { SetValue(ref partyId, value); }
        }
        private string ethnicityId;

        public string EthnicityId
        {
            get { return SetDefault(ref ethnicityId); }
            set { SetValue(ref ethnicityId, value); }
        }
        public Ethnicity Ethnicity
        {
            get {
                return Ethnicities.Instance.Find(x => x.UniqueId == PartyId);
            }
        }

    }
}
