using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLearning
{
    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Human()
        {

        }

        public void Introduce()
        {
            Console.WriteLine("hi, my full name is " + this.Name + " " + this.Surname
                                 + ". " + "I am " + this.Age + " years old.");
        }


    }
}
