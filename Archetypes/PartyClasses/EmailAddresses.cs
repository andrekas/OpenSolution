using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class EmailAddresses : Archetypes<EmailAddress>
    {
        public EmailAddresses Instances { get; } = new EmailAddresses();
    }
}
