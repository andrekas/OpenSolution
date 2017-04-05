using Open.Aids;
namespace Open.Archetypes.RuleClasses
{
    public class IntegerVariable : Variable<int>
    {
        public IntegerVariable() : this(string.Empty) { }
        public IntegerVariable(string name, int value = 0) : base(name, value) { }
        public new static IntegerVariable Empty { get; } = new IntegerVariable { IsReadOnly = true };
        public override bool IsEmpty() { return Equals(Empty); }
        public new static IntegerVariable Random()
        {
            var x = new IntegerVariable();
            x.SetRandomValues();
            return x;
        }
        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            valueField = GetRandom.Int32();
        }
    }
}
