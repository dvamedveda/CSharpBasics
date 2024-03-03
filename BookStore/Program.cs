using BookStore.models;

namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Actions actions = new Actions();
            Console.WriteLine("This is a book store, enter store size:");
            int storeSize = actions.AskForStoreSize();
            Store bookStore = new Store(storeSize);

            string userInput;
            bool exit = false;
            do
            {
                Console.WriteLine("If you want add book, type 'next' or 'exit' for exiting.");
                userInput = Console.ReadLine();
                if (userInput == "next")
                {
                    Book nextBook = actions.AskForBookData();
                    Console.WriteLine("Try to add book " + nextBook.GetTitle() + " to store");
                    bookStore.AddBook(nextBook);
                } else if (userInput == "exit")
                {
                    exit = true;
                } else
                {
                    Console.WriteLine("Incorrect input, please type 'next' or 'exit'.");
                }
            } while (!exit);

            
        }
    }
}
