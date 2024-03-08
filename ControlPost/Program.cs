using ControlPost.models;

namespace ControlPost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post controlPost = new Post();
            Console.WriteLine("Control Post working started...");

            Human womanOne = new Woman();
            womanOne.Age = 10;
            womanOne.FirstName = "Kate";
            womanOne.SecondName = "Blanchett";

            controlPost.ControlHuman(womanOne);

            Human womanTwo = new Woman();
            womanTwo.Age = 34;
            womanTwo.FirstName = "Selene";
            womanTwo.SecondName = "Dion";

            controlPost.ControlHuman(womanTwo);

            Human manOne = new Man();
            manOne.Age = 14;
            manOne.FirstName = "Brad";
            manOne.SecondName = "Pitt";

            controlPost.ControlHuman(manOne);

            Human manTwo = new Man();
            manTwo.Age = 65;
            manTwo.FirstName = "Binicio";
            manTwo.SecondName = "Del Toro";

            controlPost.ControlHuman(manTwo);

            Console.ReadKey();
        }
    }
}
