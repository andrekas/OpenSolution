using System;
using Open.Aids;

namespace Open.Archetypes.PartyClasses
{
    public class Person : Party
    {
        private ISOGender gender;
        //private DateTime dateOfBirth;

        //public PartyEthnicities Ethnicities => PartyEthnicities.GetPersonEthnicities(UniqueId);

        public PersonNames PersonNames => PersonNames.GetPersonNames(UniqueId);
        public PersonName PersonName => PersonNames.GetOfficial();
        public ISOGender Gender
        {
            get { return SetDefault(ref gender); }
            set { SetValue(ref gender, value); }
        }


        //public BodyMetrics BodyMetrics
        //{
        //    get
        //    {
        //        var b = new BodyMetrics();
        //        var l = BodyMetrics.Instances.FindAll(x => x.PartyId == UniqueId);
        //        b.AddRange(l);
        //        return b;
        //    }
        //}

        //public DateTime DateOfBirth
        //{
        //    get { return SetDefault(ref dateOfBirth); }
        //    set { SetValue(ref dateOfBirth, value); }
        //}
        public override string GetName()
        {
            return PersonName.ToString();
        }
        //public override PartyType Type => PartyType.Person;

        public static Person Random()
        {
            var e = new Person();
            e.SetRandomValues();
            return e;
        }
        //protected override void SetRandomValues()
        //{
        //    base.SetRandomValues();
        //    gender = GetRandom.Enum<ISOGender>();
        //    dateOfBirth = GetRandom.DateTime();
        //}
        public void AddName(PersonName name)
        {
            if (IsNull(name)) return;
            name.PersonId = UniqueId;
            PersonNames.Instance.Add(name);
        }
    }
}
