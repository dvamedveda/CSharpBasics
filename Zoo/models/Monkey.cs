using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.models
{
    internal class Monkey : AbstractAnimal
    {
        public override void AskRoar()
        {
            Console.WriteLine("Who Who Who Who");
        }
    }
}
