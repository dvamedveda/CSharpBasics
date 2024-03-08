using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPost.models
{
    internal class Man : Human
    {
        public void ShowPassport()
        {
            Console.WriteLine("There is my Man passport");
        }

        public void ShowArmyTicket()
        {
            Console.WriteLine("There is my Man army ticket");
        }
    }
}
