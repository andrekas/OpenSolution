using Open.Aids;

namespace Open.Archetypes.PartyClasses
{
    public class TelecomAddress
    {
        private string areaCode;
        private string countryCode;
        private string extension;
        private string nationalDirectDialingPrefix;
        private string number;
        private string physicalType;

        public string AreaCode
        {
            get { return Str.EmptyIfNull(areaCode); }
            set { areaCode = value; }
        }
        public string CountryCode
        {
            get { return Str.EmptyIfNull(countryCode); }
            set { countryCode = value; }
        }
        public string Extension
        {
            get { return Str.EmptyIfNull(extension); }
            set { extension = value; }
        }
        public string NationalDirectDialingPrefix
        {
            get { return Str.EmptyIfNull(nationalDirectDialingPrefix); }
            set { nationalDirectDialingPrefix = value; }
        }
        public string Number
        {
            get { return Str.EmptyIfNull(number); }
            set { number = value; }
        }
        public string PhysicalType
        {
            get { return Str.EmptyIfNull(physicalType); }
            set { physicalType = value; }
        }
    }
}