using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemapOOP_sConcept
{
    internal class MethodOverloading
    {
        public void Calculate(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Sum of integers: {result}");
        }

        public void Calculate(double a, double b)
        {
            double result = a + b;
            Console.WriteLine($"Sum of doubles: {result}");
        }
    }
}
