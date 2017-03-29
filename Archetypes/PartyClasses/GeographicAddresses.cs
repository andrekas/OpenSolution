using System.Linq;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class GeographicAddresses : Archetypes<GeographicAddress>
    {
        public static GeographicAddresses Instances { get; } = new GeographicAddresses();
        public static GeographicAddress GetAddressLines(string address)
        {
            return Instances.ToList().Find(x => x.AddressLines == address);
        }
        public static GeographicAddress GetCity (string address)
        {
            return Instances.ToList().Find(x => x.City == address);
        }
        public  GeographicAddress GetCountry(string address)
        {
            return Instances.ToList().Find(x => x.Country == address);
        }
        public static GeographicAddress GetRegionOrState (string address)
        {
            return Instances.ToList().Find(x => x.RegionOrState == address);
        }
        public static GeographicAddress GetZipOrPostcode (string address)
        {
            return Instances.ToList().Find(x => x.ZipOrPostcode == address);
        }
    }
}
