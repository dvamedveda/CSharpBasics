using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.models
{
    public class AbstractAnimal
    {
        public string Name { get; set; }

        public virtual void AskRoar()
        {
            Console.WriteLine("Abstract animal Roar");
        }
    }
}
