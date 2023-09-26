using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemapOOP_sConcept
{
    internal class NumCalculatorTypeCheck
    {
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Sum of integers: {result}");
        }

        public void Add(double a, double b)
        {
            double result = a + b;
            Console.WriteLine($"Sum of doubles: {result}");
        }
    }
}
