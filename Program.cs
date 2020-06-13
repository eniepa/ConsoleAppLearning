using System;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person = new Human();

            person.Name = "Jennifer";
            person.Surname = "Lopez";
            person.Age = 25;

            person.Introduce();

            person.Name = "Anna";
            person.Introduce();

            person.AddNumbers(12, 52);
        }

    }

   
}
