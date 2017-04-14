using Open.Aids;
using Open.Archetypes.BaseClasses;


namespace Open.Archetypes.PartyClasses
{
    public class Ethnicity : UniqueEntity

    {
    private string ethnicityName;
    private string description;
    private string partyId;

    public string PartyId
        {
            get { return SetDefault(ref partyId); }
            set { SetValue(ref partyId, value); }
        }

        public string EthnicityName
    {
            get { return SetDefault(ref ethnicityName); }
            set { SetValue(ref ethnicityName, value); }
        }

    public string Description
    {
            get { return SetDefault(ref description); }
            set { SetValue(ref description, value); }
        }

        public static Ethnicity Random()
        {
            var e = new Ethnicity();
            e.SetRandomValues();
            return e;
        }
        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            ethnicityName = GetRandom.String();
            description = GetRandom.String();
            
        }
    }
}
