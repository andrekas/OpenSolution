using System;
using Open.Aids;
using Open.Archetypes.BaseClasses;


namespace Open.Archetypes.PartyClasses
{
    public class PersonName: TemporalEntity
    {
        private string prefix;
        private string givenName;
        private string middleName;
        private string familyName;
        private string prefferedName;
        private string suffix;
        private string use;


        public string Prefix
        {
            get { return Str.EmptyIfNull(prefix); }
            set { prefix = value; }
        }
        public string GivenName
        {
            get { return Str.EmptyIfNull(givenName); }
            set { givenName = value; }
        }

        public string MiddleName
        {
            get { return Str.EmptyIfNull(middleName); }
            set { middleName = value; }
        }
        public string FamilyName
        {
            get { return Str.EmptyIfNull(familyName); }
            set { familyName = value; }
        }
        public string PrefferedName
        {
            get { return Str.EmptyIfNull(prefferedName); }
            set { prefferedName = value; }
        }

        public string Suffix
        {
            get { return Str.EmptyIfNull(suffix); }
            set { suffix = value; }
        }

        public string Use
        {
            get { return Str.EmptyIfNull(use); }
            set { use = value; }
        }

        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

    }
}
