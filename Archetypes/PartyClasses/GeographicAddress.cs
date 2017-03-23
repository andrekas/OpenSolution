using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class GeographicAddress: Archetype

    {
    private string addressLines;
    private string city;
    private string country;
    private string regionOrState;
    private string zipOrPostcode;

    public string AddressLines
    {
        get { return Str.EmptyIfNull(addressLines); }
        set { addressLines = value; }
    }

    public string City
    {
        get { return Str.EmptyIfNull(city); }
        set { city = value; }
    }

    public string Country
    {
        get { return Str.EmptyIfNull(country); }
        set { country = value; }
    }

    public string RegionOrState
    {
        get { return Str.EmptyIfNull(regionOrState); }
        set { regionOrState = value; }
    }

    public string ZipOrPostcode
    {
        get { return Str.EmptyIfNull(zipOrPostcode); }
        set { zipOrPostcode = value; }
    }


    }
}