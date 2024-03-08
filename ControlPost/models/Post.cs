using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPost.models
{
    public class Post
    {
        public Post() { }
        public void ControlHuman(Human human)
        {
            Console.WriteLine("Hi, who you are ?");
            human.answerName();
            human.answerAge();
            Console.WriteLine("Ok, show your document");
            if (human.Age > 16)
            {
                if (human is Woman woman)
                {
                    woman.ShowPassport();
                    woman.ShowPerinatalCart();
                }
                else if (human is Man man)
                {
                    man.ShowPassport();
                    man.ShowArmyTicket();
                }
            } else
            {
                human.ShowBirthDocument();
            }
            Console.WriteLine();
        }
    }
}
