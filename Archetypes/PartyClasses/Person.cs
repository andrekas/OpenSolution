using System;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class Person : BaseEntity<Party>
    {
        private string name;
        private string personNameId;
        private ISOGender gender;
        private Ethnicity ethnicity;
       private BodyMetric bodyMetric;
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


        public BodyMetric BodyMetric
        {
            get { return SetDefault(ref bodyMetric); }
            set { SetValue(ref bodyMetric, value); }
        }

        public DateTime DateOfBirth
        {
            get { return SetDefault(ref dateOfBirth); }
            set { SetValue(ref dateOfBirth, value); }
        }


        public override Party Type { get; }

        public static Person Random()
        {
            var e = new Person();
            e.SetRandomValues();
            return e;
        }
    }
}
