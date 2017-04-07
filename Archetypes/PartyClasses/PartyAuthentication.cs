using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class PartyAuthentication : BaseEntity
    {
        public static PartyAuthentication Random()
        {
            var a = new PartyAuthentication();
            a.SetRandomValues();
            return a;
        }
    }
}