using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPost.models
{
    public class Human
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }

        public void answerAge()
        {
            Console.WriteLine("I'm is " + Age + " years old.");
        }

        public void answerName()
        {
            Console.WriteLine("I'm is " + FirstName + " " + SecondName + ".");
        }

        public void ShowBirthDocument()
        {
            Console.WriteLine("There is my birth document");
        }
    }
}
