using Zoo.models;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractAnimal[] animals = new AbstractAnimal[4];

            AbstractAnimal cat = new Cat();
            cat.Name = "Barsik";

            AbstractAnimal dog = new Dog();
            dog.Name = "Tuzik";

            AbstractAnimal duck = new Duck();
            duck.Name = "Esmeralda";

            AbstractAnimal monkey = new Monkey();
            monkey.Name = "Charlie";

            animals[0] = cat;
            animals[1] = dog;
            animals[2] = duck;
            animals[3] = monkey;

            for (int i = 0; i < animals.Length; i++)
            {
                AbstractAnimal animal = animals[i];
                Console.WriteLine(animal.Name + " says:");
                animal.AskRoar();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
