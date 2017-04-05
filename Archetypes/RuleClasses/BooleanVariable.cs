using Open.Aids;
namespace Open.Archetypes.RuleClasses
{
    public class BooleanVariable : Variable<bool>
    {
        public BooleanVariable() : this(string.Empty) { }
        public BooleanVariable(string name, bool value = false) : base(name, value) { }
        public new static BooleanVariable Empty { get; } = new BooleanVariable { IsReadOnly = true };
        public override bool IsEmpty() { return Equals(Empty); }
        public new static BooleanVariable Random()
        {
            var x = new BooleanVariable();
            x.SetRandomValues();
            return x;
        }
        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            valueField = GetRandom.Bool();
        }
    }
}
