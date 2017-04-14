using Open.Archetypes.BaseClasses;


namespace Open.Archetypes.PartyClasses
{
    public class Ethnicities : Archetypes<Ethnicity>
    {
        public static Ethnicities Instance { get; } = new Ethnicities();
        
    }
}
