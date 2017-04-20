using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Open.Archetypes.PartyClasses
{
    public class ISOCountryCode: Locale

    {
        public static List<RegionInfo> GetCountriesByIso3166()
        {
            List<RegionInfo> countries = new List<RegionInfo>();
            foreach (CultureInfo culture in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                RegionInfo country = new RegionInfo(culture.LCID);
                if (countries.Where(p => p.Name == country.Name).Count() == 0)
                    countries.Add(country);
            }
            return countries.OrderBy(p => p.EnglishName).ToList();
        }

        public static List<RegionInfo> GetCountriesByCode(List<string> codes)
        {
            List<RegionInfo> countries = new List<RegionInfo>();
            if (codes != null && codes.Count > 0)
            {
                foreach (string code in codes)
                {
                    try
                    {
                        countries.Add(new RegionInfo(code));
                    }
                    catch (Exception)
                    {
                        return null; //  Ignores the invalid culture code?
                    }
                }
            }
            return countries.OrderBy(p => p.EnglishName).ToList();
        }
    }
}
