using System;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class Person : Party
    {
        private string name;
        private string personNameId;
        private ISOGender gender;
        private Ethnicity ethnicity;
        private DateTime dateOfBirth;


        public PersonNames PersonName
        {
            get { return PersonNames.GetPersonNames(UniqueId); }
        }

        public Ethnicity Ethnicity
        {
            get { return SetDefault(ref ethnicity); }
            set { SetValue(ref ethnicity, value); }
        }

        public ISOGender Gender
        {
            get { return SetDefault(ref gender); }
            set { SetValue(ref gender, value); }
        }


        public BodyMetrics BodyMetrics
        {
            get
            {
                var b = new BodyMetrics();
                var l = BodyMetrics.Instances.FindAll(x=> x.PartyId == UniqueId);
                b.AddRange(l);
                return b;
            }
        }

        public DateTime DateOfBirth
        {
            get { return SetDefault(ref dateOfBirth); }
            set { SetValue(ref dateOfBirth, value); }
        }


        public override PartyType Type => PartyType.Person;

        public static Person Random()
        {
            var e = new Person();
            e.SetRandomValues();
            return e;
        }
    }
}
