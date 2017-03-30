namespace Soft.Models
{
    public class RoleandParty
    {
        public int ID { get; set; }
        public string GivenName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male, Female
    }
}