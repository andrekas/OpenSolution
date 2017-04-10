using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class Address : BaseEntity

    {
        public static Address Random()
        {
            var e = new Address();
            e.SetRandomValues();
            return e;
        }

    }
}
