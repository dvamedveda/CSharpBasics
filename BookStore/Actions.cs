using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookStore.models;
namespace BookStore
{
    public class Actions
    {

        public int AskForStoreSize()
        {
            string sizeInput;
            int size;
            bool sizeCorrect = false;
            do
            {
                sizeInput = Console.ReadLine();
                if (!int.TryParse(sizeInput, out size))
                {
                    Console.WriteLine("Incorrect store size.");
                }
                else
                {
                    Console.WriteLine("Size accepted, current store size = " + sizeInput);
                    sizeCorrect = true;
                }

            } while (!sizeCorrect);
            return size;
        }

        public Book AskForBookData()
        {
            Book result = new Book();
            Console.WriteLine("Type books author, please");
            result.SetAuthor(Console.ReadLine());
            Console.WriteLine("Type books title, please");
            result.SetTitle(Console.ReadLine());
            Console.WriteLine("Type books description, please");
            result.SetDescription(Console.ReadLine());
            return result;
        }
    }
}
