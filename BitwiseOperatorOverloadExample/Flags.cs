
namespace BitwiseOperatorOverloadExample
{
    public class Flags
    {
        public int Value { get; set; }

        public Flags(int value)
        {
            Value = value;
        }

        // Bitwise AND
        public static Flags operator &(Flags a, Flags b)
        {
            return new Flags(a.Value & b.Value);
        }

        // Bitwise OR
        public static Flags operator |(Flags a, Flags b)
        {
            return new Flags(a.Value | b.Value);
        }

        // Bitwise XOR
        public static Flags operator ^(Flags a, Flags b)
        {
            return new Flags(a.Value ^ b.Value);
        }

        // Bitwise NOT
        public static Flags operator ~(Flags a)
        {
            return new Flags(~a.Value);
        }

        public static implicit operator Flags(int value)
        {
            return new Flags(value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

}
