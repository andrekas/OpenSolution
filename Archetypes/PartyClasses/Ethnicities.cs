using Open.Archetypes.BaseClasses;


namespace Open.Archetypes.PartyClasses
{
    public class Ethnicities : Archetypes<Ethnicity>
    {
        public Ethnicities Instances { get; } = new Ethnicities();
        //public static Ethnicity GetPersonEthnicity(string name)
        //{
        //    //return Instances.ToList().Find(x => x.Name == name);
        //}
    }
}
