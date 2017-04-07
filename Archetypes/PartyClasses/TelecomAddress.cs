using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class TelecomAddress: Address

    {
    private string areaCode;
    private string countryCode;
    private string extension;
    private string nationalDirectDialingPrefix;
    private string number;
    private string physicalType;

    public string AreaCode
    {
        get { return SetDefault(ref areaCode); }
        set { SetValue(ref areaCode, value); }
    }

    public string CountryCode
    {
            get { return SetDefault(ref countryCode); }
            set { SetValue(ref countryCode, value); }
        }

    public string Extension
    {
            get { return SetDefault(ref extension); }
            set { SetValue(ref extension, value); }
        }

    public string NationalDirectDialingPrefix
    {
            get { return SetDefault(ref nationalDirectDialingPrefix); }
            set { SetValue(ref nationalDirectDialingPrefix, value); }
        }

    public string Number
    {
            get { return SetDefault(ref number); }
            set { SetValue(ref number, value); }
        }

    public string PhysicalType
    {
            get { return SetDefault(ref physicalType); }
            set { SetValue(ref physicalType, value); }
        }

        public static TelecomAddress Random()
        {
            var e = new TelecomAddress();
            e.SetRandomValues();
            return e;
        }
    }
}