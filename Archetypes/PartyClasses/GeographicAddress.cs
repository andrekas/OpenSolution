namespace Open.Archetypes.PartyClasses
{
    public class GeographicAddress: Address

    {
    private string addressLines;
    private string city;
    private string country;
    private string regionOrState;
    private string zipOrPostcode;

        public string AddressLines
        {
            get { return SetDefault(ref addressLines); }
            set { SetValue(ref addressLines, value); }
        }

        public string City
        {
            get { return SetDefault(ref city); }
            set { SetValue(ref city, value); }
        }

        public string Country
        {
            get { return SetDefault(ref country); }
            set { SetValue(ref country, value); }
        }
        public string RegionOrState
    {
            get { return SetDefault(ref regionOrState); }
            set { SetValue(ref regionOrState, value); }
        }

    public string ZipOrPostcode
    {
            get { return SetDefault(ref zipOrPostcode); }
            set { SetValue(ref zipOrPostcode, value); }
        }

        public static GeographicAddress Random()
        {
            var e = new GeographicAddress();
            e.SetRandomValues();
            return e;
        }

    }
}