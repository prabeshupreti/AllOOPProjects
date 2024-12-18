
namespace Calculator
{
    public class Calc
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public int Add() 
        {
            return Number1 + Number2;
        }

        public int Add(int A, int B)
        {
            return A + B;
        }

        public int Add(int A, int B, int C)
        {
            return A + B + C;
        }

        public float Add(float A, float B)
        {
            return A + B;
        }

        public long Add(long A, long B)
        {
            return A + B;
        }

        public int Difference()
        {
            return Number1 - Number2;
        }
    }
}
