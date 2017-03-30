using System;
using System.Linq;
using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class PersonNames: Archetypes<PersonName>
    {
        public static PersonNames Instances { get; } = new PersonNames();

        public static PersonName FindPersonNameById(string id)
        {
            return Instances.Find(x => x.Id == id);
        }
        //public static PersonName GetGivenName(string name)
        //{
        //    return Instances.Find(x => x.GivenName == name);
        //}

        //public static PersonName GetMiddleName(string name)
        //{
        //    return Instances.ToList().Find(x => x.MiddleName == name);
        //}

        //public static PersonName GetFamilyName(string name)
        //{
        //    return Instances.ToList().Find(x => x.FamilyName == name);
        //}

        //public static PersonName GetPrefferedName(string name)
        //{
        //    return Instances.ToList().Find(x => x.PrefferedName == name);
        //}

        //public static PersonName GetSuffix (string suffix)
        //{
        //    return Instances.ToList().Find(x => x.Suffix == suffix);
        //}

        //public static PersonName GetUse(string use)
        //{
        //    return Instances.ToList().Find(x => x.Use == use);
        //}

        //public static PersonName GetPrefix(string prefix)
        //{
        //    return Instances.ToList().Find(x => x.Prefix == prefix);
        //}

        //public static PersonName GetDateValidFrom(DateTime date)
        //{
        //    return Instances.ToList().Find(x => x.ValidFrom == date);
        //}
        //public static PersonName GetDateValidTo(DateTime date)
        //{
        //    return Instances.ToList().Find(x => x.ValidTo == date);
        //}
        public static PersonNames Random()
        {
            var e = new PersonNames();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++)
                e.Add(PersonName.Random());
            return e;
        }

    }
}
