

namespace Act.Domain.ValueObjects
{
    public sealed class Price : ValueObject<Price>
    {
        public enum CurrencyType
        {
            JPY,
            USD,
            EUR
        }

        public CurrencyType Currency { get; }

        public int Value { get; }


        public Price(CurrencyType currency, int val)
        {
            Currency = currency;
            Value = val;
        }

        protected override bool EqualsCore(Price other)
        {
            return (Currency == other.Currency && Value == other.Value);
        }
    }
}
