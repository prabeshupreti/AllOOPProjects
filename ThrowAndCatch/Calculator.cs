using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowAndCatch
{
    public class Calculator
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public int Add()
        {
            return Number1 + Number2;
        }

        public int Difference()
        {
            return Math.Abs(Number1 - Number2);
        }

        public int Product()
        {
            return Number1 * Number2;
        }

        public int Division()
        {
            if (Number2 == 0) 
            {
                throw new DivideByZeroException();
            }

            return Number1 / Number2;
        }
    }
}
