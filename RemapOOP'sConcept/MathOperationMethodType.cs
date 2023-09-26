using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemapOOP_sConcept
{
    internal class MathOperationMethodType
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0;
            }
            return a / b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0.0;
            }
            return a / b;
        }
    }
}
