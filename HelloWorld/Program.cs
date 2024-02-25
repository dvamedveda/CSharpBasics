using System;

namespace BaseOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a multiplicator program.");
            Console.WriteLine("Enter number:");
            string input = Console.ReadLine();

            Console.WriteLine("Checking input for null, replacing to 1 if is null");
            input = input ?? "1";

            Console.WriteLine("Checking input for space or empty string, replacing to 1, if true");
            input = input == " " || input == "" ? "1" : input;

            int number;
            Console.WriteLine("Checking for numerical");
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("It is not a number, replacing to 1");
                number = 1;
            } else
            {
                number = Convert.ToInt32(input);
            }

            
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
