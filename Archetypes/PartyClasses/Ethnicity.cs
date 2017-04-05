using Open.Archetypes.BaseClasses;


namespace Open.Archetypes.PartyClasses
{
    public class Ethnicity: Archetype

    {
    private string ethnicityName;
    private string description;

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
    }
}
