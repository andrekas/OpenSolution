using System;
using Open.Aids;
namespace Open.Archetypes.RuleClasses
{
    public class DateTimeVariable : Variable<DateTime>
    {
        public DateTimeVariable() : this(string.Empty) { }
        public DateTimeVariable(string name, DateTime? value = null) : base(name, value ?? DateTime.MinValue) { }
        public new static DateTimeVariable Empty { get; } = new DateTimeVariable { IsReadOnly = true };
        public override bool IsEmpty() { return Equals(Empty); }
        public new static DateTimeVariable Random()
        {
            var x = new DateTimeVariable();
            x.SetRandomValues();
            return x;
        }
        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            valueField = GetRandom.DateTime();
        }
    }
}
