namespace Soft.Models
{
    public class RoleandParty
    {
        public int ID { get; set; }
        public string AllInOne { get { return GivenName + " " + LastName; }}
        public string GivenName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
       
        public string Address { get; set; }

    }

    public enum Gender
    {
        Male, Female
    }
}