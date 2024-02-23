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
            if (number % 2 == 0)
            {
                Console.WriteLine("This number is odd number!");
            }
            else
            {
                Console.WriteLine("This number is not odd number!");
            }
            if (number >= 1000)
            {
                Console.WriteLine("Number " + number.ToString() + " is greater than 1000.");
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
