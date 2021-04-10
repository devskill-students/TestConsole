using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number : ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose a Sign : (+)(-)(*)(/) ");
            string sign = Console.ReadLine();

            int add = firstNumber + secondNumber;
            int minus = firstNumber - secondNumber;
            int multiply = firstNumber * secondNumber;
            int divide = firstNumber / secondNumber;

            if (sign == "+")
            {
                Console.WriteLine("The Result is : " + add);
            }

            else if (sign == "-")
            {
                Console.WriteLine("The Result is : " + minus);
            }

            else if (sign == "-")
            {
                Console.WriteLine("The Result is : " + multiply);
            }

            else if (sign == "-")
            {
                Console.WriteLine("The Result is : " + divide);
            }
        }

    }
}