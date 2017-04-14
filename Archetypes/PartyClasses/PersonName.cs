using Open.Aids;
using Open.Archetypes.BaseClasses;


namespace Open.Archetypes.PartyClasses
{
    public class PersonName: UniqueEntity
    {
        private string personId;
        private string prefix;
        private string givenName;
        private string middleName;
        private string familyName;
        private string prefferedName;
        private string suffix;
        private string use;
        public string PersonId
        {
            get { return SetDefault(ref personId); }
            set { SetValue(ref personId, value); }
        }
        public Person Person
        {
            get { return People.FindPersonById(PersonId); }
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
        public bool IsOfficial => Use == "Official";
        public static PersonName Empty { get; } = new PersonName();
        public static PersonName Random()
        {
            var e = new PersonName();
            e.SetRandomValues();
            return e;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            personId = GetRandom.String();
            prefix = GetRandom.String();
            givenName = GetRandom.String();
            middleName = GetRandom.String();
            familyName = GetRandom.String();
            prefferedName = GetRandom.String();
            suffix = GetRandom.String();
            use = GetRandom.String();
        }
    }
}
