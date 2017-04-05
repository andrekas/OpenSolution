using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class WebpageAddress: TemporalEntity
    {
        private string url;

        public string Url
        {
            get { return SetDefault(ref url); }
            set { SetValue(ref url, value); }
        }

        public static WebpageAddress Random()
        {
            var e = new WebpageAddress();
            e.SetRandomValues();
            return e;
        }
    }
}