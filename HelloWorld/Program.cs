using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a multiplicator program.");
            Console.WriteLine("Enter number:");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            Console.WriteLine("Number is: " + number.ToString());
            Console.WriteLine("Multiplied number is: " + (number * number).ToString());
            Console.ReadKey();
        }
    }
}
