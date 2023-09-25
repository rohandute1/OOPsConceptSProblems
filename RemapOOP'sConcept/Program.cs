using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemapOOP_sConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Opp's concepts peoblems");
            bool continueExecution = true;
            while (continueExecution)
            {  
                Console.WriteLine("Please choose any one of the following program:");
                Console.WriteLine("1.Class Object Program\n2.Inheritance concept");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        Person person1 = new Person("John", 30);
                        Person person2 = new Person("Alice", 25);

                        Console.WriteLine("Person 1:");
                        person1.DisplayInfo();

                        Console.WriteLine("\nPerson 2:");
                        person2.DisplayInfo();
                        break;

                    case 2:
                        Car myCar = new Car("Toyota", "Camry", 2022, 200);

                        Console.WriteLine("Vehicle Information:");
                        myCar.DisplayInfo();

                        Console.WriteLine("\nCar Information:");
                        myCar.DisplayCarInfo();
                        break;

                    default:
                        Console.WriteLine("Invalid option, Please select a valid program.");
                        break;
                }
                Console.WriteLine("Do you want to continue?(yes or no)");
                string userInput = Console.ReadLine().ToLower();
                if (userInput != "yes")
                {
                    continueExecution = false;
                }
            }

            Console.ReadLine();


        }
    }
}
