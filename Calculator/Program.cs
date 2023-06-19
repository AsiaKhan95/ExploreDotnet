using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagment;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Login");
            Console.WriteLine("=======================");
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();

            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

            //Authentication
            Authentication auth = new Authentication();
            if (!auth.Login(username, password))
            {
                Console.WriteLine("Invalid Credentials!!");
            }
            else
            {
                Console.WriteLine("Calculator Application");
                Console.WriteLine("=======================");
                Console.WriteLine(auth.UserHome(username));

                //take input 1
                //take input 2
                //
                bool endApp = false;
                double num1 = 0;
                double num2 = 0;

                Console.WriteLine("Enter first value: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second value: ");
                num2 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Chose option: ");
                Console.WriteLine("\t a: Addition ");
                Console.WriteLine("\t s: Subtraction ");
                Console.WriteLine("\t p: Product ");
                Console.WriteLine("\t d: Division ");
                char operation = Convert.ToChar(Console.ReadLine());
                if (operation == 'd') {
                    while (num2 == 0) {
                        Console.WriteLine("number two cannot be 0");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                }
                Console.WriteLine(Calculator.DoCalculation(num1, num2, operation));

            }
            Console.ReadKey();
        }
    }
}
