using Open.Aids;

namespace Open.Archetypes.PartyClasses
{
    public class WebpageAddress: Address
    {
        private string url;

        public string Url
        {
            get { return SetDefault(ref url); }
            set { SetValue(ref url, value); }
        }

        public new static WebpageAddress Random()
        {
            var e = new WebpageAddress();
            e.SetRandomValues();
            return e;
        }
       
        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            url = GetRandom.String();
        }
    }
}