using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPost.models
{
    public class Woman : Human
    {
        public void ShowPassport()
        {
            Console.WriteLine("There is my Woman passport");
        }

        public void ShowPerinatalCart()
        {
            Console.WriteLine("There is my Woman perinatal card");
        }
    }
}
