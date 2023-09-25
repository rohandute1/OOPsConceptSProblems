using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemapOOP_sConcept
{
    internal class Calculator
    {
        private int AddIntegers(int a, int b)
        {
            return a + b;
        }

        private double AddDoubles(double a, double b)
        {
            return a + b;
        }

        public void CalculateAndDisplay(int a, int b)
        {
            int result = AddIntegers(a, b);
            Console.WriteLine($"Sum of integers: {result}");
        }

        public void CalculateAndDisplay(double a, double b)
        {
            double result = AddDoubles(a, b);
            Console.WriteLine($"Sum of doubles: {result}");
        }
    }
}
