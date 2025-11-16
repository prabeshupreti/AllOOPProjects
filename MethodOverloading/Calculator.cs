using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Calculator
    {


        public Calculator()
        {
        }


        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, params int[] Numbers)
        {
            return a + b + Numbers.Sum();
        }

        public float Add(float a, float b, params float[] Numbers)
        {
            return a + b + Numbers.Sum();
        }

        public double Add(double a, double b, params double[] Numbers)
        {
            return a + b + Numbers.Sum();
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public float Add(float a, float b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
