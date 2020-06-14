using System;
using System.Threading.Tasks.Dataflow;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Human person = new Human("Johnny", "Depp", 54, "Brown");

            person.Introduce();


            person.AddNumbers(person.Age,50);
        }
    }

    
}
