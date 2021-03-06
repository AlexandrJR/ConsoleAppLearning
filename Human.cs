﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ConsoleAppLearning
{
    class Human
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public string Eyecolor { get; }

        public Human(string name, string surname, int age, string eyeColor)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Eyecolor = eyeColor;
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, my full name is " + this.Name + " " 
            + this.Surname + ". " + "I am " + this.Age + " years old.");
        }

        public void AddNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
