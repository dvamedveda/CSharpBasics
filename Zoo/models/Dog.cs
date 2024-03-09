using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.models
{
    internal class Dog : AbstractAnimal
    {
        public override void AskRoar()
        {
            Console.WriteLine("Whooof Whooof!");
        }
    }
}
