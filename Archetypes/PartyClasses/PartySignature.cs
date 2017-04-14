using System;
using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Archetypes.PartyClasses {
    public class PartySignature : UniqueEntity {
        private string partyId;
        private PartyAuthentication authentication;
        private string resolution;

        public string PartyId
        {
            get { return SetDefault(ref partyId); }
            set { SetValue(ref partyId, value); }
        }

        public PartyAuthentication Authentication
        {
            get { return SetDefault(ref authentication); }
            set { SetValue(ref authentication, value); }
        }

        public string Resolution
        {
            get { return SetDefault(ref resolution); }
            set { SetValue(ref resolution, value); }
        }

        public override bool IsEmpty()
        {
            return Equals(Empty);
        }

        public static PartySignature Random()
        {
            var s = new PartySignature();
            s.SetRandomValues();
            return s;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            resolution = GetRandom.String();
            authentication = PartyAuthentication.Random();
            partyId = GetRandom.String(5, 7);
        }

        public static PartySignature Empty { get; } = new PartySignature();

        public bool IsSigned()
        {
            if (IsSpaces(PartyId)) return false;
            if (Valid.From == DateTime.MinValue) return false;
            if (Valid.From == DateTime.MaxValue) return false;
            return true;
        }
    }
}
