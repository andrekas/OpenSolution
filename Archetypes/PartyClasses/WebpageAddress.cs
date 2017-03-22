using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class WebpageAddress: Archetype
    {
        private string url;

        public string Url
        {
            get { return Str.EmptyIfNull(url); }
            set { url = value; }
        }
    }
}