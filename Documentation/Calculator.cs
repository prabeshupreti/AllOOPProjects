using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentation
{

    /// <summary>
    /// A Calculator class to perform basic mathematic calculation.
    /// </summary>
    public class Calculator
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        /// <summary>
        /// A method to add two numbers.
        /// </summary>
        /// <returns>The sum of two numbers.</returns>
        public int Add()
        {
            return Number1 + Number2;
        }

        /// <summary>
        /// A method to find the difference between the numbers.
        /// </summary>
        /// <returns>The sum of difference between two numbers.</returns>
        public int Difference()
        {
            return Math.Abs(Number1 - Number2);
        }

        /// <summary>
        /// A method to find the product of the two numbers.
        /// </summary>
        /// <returns>The product of two numbers.</returns>
        public int Product()
        {
            return Number1 * Number2;
        }
        /// <summary>
        /// A method to find the division of a number by another number. 
        /// </summary>
        /// <returns>The divised number.</returns>
        public int Division()
        {
            return Number1 / Number2;
        }
    }
}
