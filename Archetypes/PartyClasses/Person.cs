using RoleAndParty.Aids;
using System;

namespace RoleAndParty.Classes
{
    public class Person
    {
        private string name;
        private PersonName personName;
        private ISOGender gender;
        private Ethnicity ethnicity;
        private BodyMetric bodyMetric;
        public static DateTime MinDateOfBirth => new DateTime(1900, 1, 1);
        public static DateTime MaxDateOfBirth => new DateTime(2100, 1, 1);
        private DateTime dateOfBirth = MinDateOfBirth;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Ethnicity Ethnicity
        {
            get { return ethnicity; }
            set { ethnicity = value; }
        }


        //public DateTime DateOfBirth
        //{
        //    get { return DateOfBirth; }
        //    set { DateOfBirth = value; }
        //}

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                if (value < MinDateOfBirth) return;
                if (value > MaxDateOfBirth) return;
                dateOfBirth = value;
            }
        }

        public PersonName PersonName
        {
            get { return personName; }
            set { personName = value; }
        }

        public ISOGender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public BodyMetric BodyMetric
        {
            get { return bodyMetric; }
            set { bodyMetric = value; }
        }


    }
}
