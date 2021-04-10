using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");
            string ans = Console.ReadLine();
            Console.WriteLine("Congratulations! You are registered " + ans);
            Console.WriteLine(ans + " has " + ans.Length + " characters!");
        }
    }
}