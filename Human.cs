﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLearning
{
    class Human
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; private set; }

        public Human(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, my full name is {this.Name} {this.Surname}. I am {this.Age} years old.");
        }

        public void AddNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void SayName()
        {
            Console.WriteLine(this.Name);
        }

        public void SetAge(int age)
        {
            if (age < 0)
            {
                return;
            }
            else if (age < this.Age)
            {
                Console.WriteLine("The new age is younger, are you shure to change y/n?");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    this.Age = age;
                }
                else
                {
                    return;
                }
            }
            else
            {
                this.Age = age;
            }
            
            
        }
    }
}
