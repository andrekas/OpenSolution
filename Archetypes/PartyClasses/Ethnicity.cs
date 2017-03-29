using Open.Aids;
using Open.Archetypes.BaseClasses;


namespace Open.Archetypes.PartyClasses
{
    public class Ethnicity: Archetype

    {
    private string ethnicityName;
    private string description;

    public string EthnicityName
    {
        get { return Str.EmptyIfNull(ethnicityName); }
        set { ethnicityName = value; }
    }

    public string Description
    {
        get { return Str.EmptyIfNull(description); }
        set { description = value; }
    }
    }
}
