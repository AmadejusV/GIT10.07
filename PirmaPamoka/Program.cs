using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            static void add(){
                Console.WriteLine("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 + num2;
                Console.WriteLine("The result is: " + result);
            }

            static void divide()
            {
                Console.WriteLine("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 / num2;
                Console.WriteLine("The result is: " + result);
            }

            static void subtract()
            {
                Console.WriteLine("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 - num2;
                Console.WriteLine("The result is: " + result);
            }

            static void multiply()
            {
                Console.WriteLine("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 * num2;
                Console.WriteLine("The result is: " + result);
            }


            static void calculator()
            {
                Console.WriteLine("What do you want to do? enter: add, subtract, multiply, divide");
                string operation = Console.ReadLine();
            
                switch (operation)
                {
                    case "add":
                        add();
                        break;
                    case "divide":
                        divide();
                        break;
                    case "multiply":
                        multiply();
                        break;
                    case "subtract":
                        subtract();
                        break;
                    default:
                        Console.WriteLine("Neteisinga ivestis");
                        break;
                }
            }

            calculator();
        }
    }
}
