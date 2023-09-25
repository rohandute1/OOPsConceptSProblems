using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemapOOP_sConcept
{
    internal class VariableTypesDemo
    {
        private int instanceVar = 42;
        private double anotherInstanceVar = 3.14;
        private string name = "John";

        private static int staticVar = 10;
        private static double staticDoubleVar = 2.5;
        private static string staticName = "Alice";

        public void DisplayInstanceVariables()
        {
            Console.WriteLine($"Instance Variable: {instanceVar}");
            Console.WriteLine($"Another Instance Variable: {anotherInstanceVar}");
            Console.WriteLine($"Name: {name}");
        }

        public static void DisplayStaticVariables()
        {
            Console.WriteLine($"Static Variable: {staticVar}");
            Console.WriteLine($"Static Double Variable: {staticDoubleVar}");
            Console.WriteLine($"Static Name: {staticName}");
        }
    }
}
