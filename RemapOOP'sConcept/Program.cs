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
                Console.WriteLine("1.Class Object Program\n2.Inheritance Problem\n3.Polymorphism overriding Concept\n" +
                    "4.Method Overloading Concept\n5.Encapsulation Problem");
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

                    case 3:
                        
                        Shape[] shapes = new Shape[3];
                        shapes[0] = new Shape();
                        shapes[1] = new Circle();
                        shapes[2] = new Rectangle();

                        foreach (var shape in shapes)
                        {
                            shape.Draw();
                        }
                        break;
                    case 4:
                        MethodOverloading calculator = new MethodOverloading();

                        int intNum1 = 5, intNum2 = 10;
                        double doubleNum1 = 3.14, doubleNum2 = 2.0;

                        calculator.Calculate(intNum1, intNum2);
                        calculator.Calculate(doubleNum1, doubleNum2);
                        break;
                    case 5:
                        Calculator cal = new Calculator();

                        int num1 = 5, num2 = 10;
                        double numb1 = 3.14, numb2 = 2.0;

                        // Accessing the CalculateAndDisplay methods using the calculator object
                        cal.CalculateAndDisplay(num1, num2);
                        cal.CalculateAndDisplay(numb1, numb2);
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
