using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleAndParty.Classes
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
