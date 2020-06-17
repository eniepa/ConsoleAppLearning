using System;
using System.Collections.Generic;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> persons = new List<Human>();

            persons.Add(new Human("Jenifer", "Lopez", 25));
            persons.Add(new Human("Anna", "Liepa", 16));
            persons.Add(new Human("Mikelis", "Jonson", 14));
            persons.Add(new Human("Agnese", "Egle", 19));

            /*  for (int i=0; i<persons.Count; i++)
              {
                  persons[i].Introduce();
              }
            */
            persons[1].SetAge(5);

            foreach(var person in persons)
            {
                person.Introduce();
            }
        }

    }

   
}
