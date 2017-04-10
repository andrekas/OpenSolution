using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class AddressUsages: Archetypes<AddressUsage>
    {
        public static AddressUsages Instance { get; } = new AddressUsages();
        public static AddressUsages GetPersonAddresses(string uniqueId)
        {
            var r = new AddressUsages();
            var l = Instance.FindAll(x => x.PartyId == uniqueId);
            r.AddRange(l);
            return r;
        }
    }
}
