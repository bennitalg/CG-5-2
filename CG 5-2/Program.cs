using System;

namespace CG_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            //declare variables 

            double num1;
            double num2;
            double total;
            char oper;

            //ask for user input of the first number

            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            //ask for user input of the mathmatical operator

            Console.WriteLine("Enter the mathmatical operator: ");
            oper = Convert.ToChar(Console.ReadLine());

            //ask user input for the second number

            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            //set an if/else if statement for user to choose to add, subtract, divide or multiply

            if (oper == '+')
            {
                total = num1 + num2;
                Console.WriteLine("Your answer is: " + total);
            }
            else if (oper == '-')
            {
                total = num1 - num2;
                Console.WriteLine("Your answer is: " + total);
            }
            else if (oper == '*')
            {
                total = num1 * num2;
                Console.WriteLine("Your answer is: " + total);
            }
            else if (oper == '/')
            {
                total = num1 / num2;
                Console.WriteLine("Your answer is: " + total);
            }
            else
            {
                Console.WriteLine("Invalid operator");

            }
            Console.ReadLine();
        }
        public class calculator
        {
            String name;

            /// <summary>
            /// text for name 
            /// </summary> creation of methods for calculator and return a value
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <returns></returns>
            public int add(int x, int y)
            {
                return x + y;
            }
            public int subtract (int x, int y)
            {
                return x - y;
            
            }
            public int multiply(int x, int y)
            {
                return x * y;
            }
            public int divide (int x, int y)
            {
                return x / y;
            }
                      
                
            
        }
    }
}
