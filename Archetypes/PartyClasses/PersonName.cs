using System;
using System.CodeDom;
using Open.Aids;
using Open.Archetypes.BaseClasses;


namespace Open.Archetypes.PartyClasses
{
    public class PersonName: TemporalEntity
    {
        public string id;
        private string prefix;
        private string givenName;
        private string middleName;
        private string familyName;
        private string prefferedName;
        private string suffix;
        private string use;
        private DateTime validFrom;
        private DateTime validTo;
        public string Id
        {
            get { return SetDefault(ref id); }
            set { SetValue(ref id, value); }
        }
        public Person Person
        {
            get { return Persons.FindPersonById(Id); }
        }
        public string Prefix
        {
            get { return SetDefault(ref prefix); }
            set { SetValue(ref prefix, value); }
        }
        public string GivenName
        {
            get { return SetDefault(ref givenName); }
            set { SetValue(ref givenName, value); }
        }

        public string MiddleName
        {
            get { return SetDefault(ref middleName); }
            set { SetValue(ref middleName, value); }
        }
        public string FamilyName
        {
            get { return SetDefault(ref familyName); }
            set { SetValue(ref familyName, value); }
        }
        public string PrefferedName
        {
            get { return SetDefault(ref prefferedName); }
            set { SetValue(ref prefferedName, value); }
        }

        public string Suffix
        {
            get { return SetDefault(ref suffix); }
            set { SetValue(ref suffix, value); }
        }

        public string Use
        {
            get { return SetDefault(ref use); }
            set { SetValue(ref use, value); }
        }

        public DateTime ValidFrom
        {
            get { return SetDefault(ref validFrom); }
            set { SetValue(ref validFrom, value); }
        }
        public DateTime ValidTo
        {
            get { return SetDefault(ref validTo); }
            set { SetValue(ref validTo, value); }
        }
        public static PersonName Random()
        {
            var e = new PersonName();
            e.SetRandomValues();
            return e;
        }

    }
}
