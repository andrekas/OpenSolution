using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class BodyMetric: UniqueEntity

    {
        private string partyId;
        public string PartyId
        {
            get { return SetDefault(ref partyId); }
            set { SetValue(ref partyId, value); }
        }

        private string name;
        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }

        private object value;
        public object Value
        {
            get { return SetDefault(ref value); }
            set { SetValue(ref this.value, value); }
        }
        public new static BodyMetric Random()
        {
            var e = new BodyMetric();
            e.SetRandomValues();
            return e;
        }
        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            partyId = GetRandom.String();
            name = GetRandom.String();
            value = GetRandom.String();
        }
    }
}
