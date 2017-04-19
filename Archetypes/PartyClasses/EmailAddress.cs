using Open.Aids;

namespace Open.Archetypes.PartyClasses
{
    public class EmailAddress: Address

    {
    private string email;

    public string Email
    {
            //get { return Str.EmptyIfNull(email); }
            //set { email = value; }
            get { return SetDefault(ref email); }
            set { SetValue(ref email, value); }
        }
        public new static EmailAddress Random()
        {
            var e = new EmailAddress();
            e.SetRandomValues();
            return e;
        }
        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            email = GetRandom.String();
        }
    }
}