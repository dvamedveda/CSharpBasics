using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.basics
{
    internal class FizzBuzz
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine("Fizz");
                } else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                } else
                {
                    Console.WriteLine(i.ToString() + " not dividing for 2 and 5");
                }
            }
            Console.ReadKey();
        }
    }
}
