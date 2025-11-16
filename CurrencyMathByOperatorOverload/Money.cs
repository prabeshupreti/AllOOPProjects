
namespace CurrencyMathByOperatorOverload
{
    public class Money
    {
        public int Dollars { get; set; }
        public int Cents { get; set; }

        public Money(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
            Normalize();
        }

        // Ensure cents < 100
        private void Normalize()
        {
            Dollars += Cents / 100;
            Cents = Cents % 100;
        }

        // Overload + operator
        public static Money operator +(Money m1, Money m2)
        {
            return new Money(m1.Dollars + m2.Dollars, m1.Cents + m2.Cents);
        }

        // Overload - operator
        public static Money operator -(Money m1, Money m2)
        {
            return new Money(m1.Dollars - m2.Dollars, m1.Cents - m2.Cents);
        }

        public override string ToString()
        {
            return $"${Dollars}.{Cents:00}";
        }
    }
}
