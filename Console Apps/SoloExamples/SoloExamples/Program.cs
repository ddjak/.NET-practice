using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloExamples
{
    class Program
    {
        class Temp
        {
            public int num = 2;
            public Temp() { num++; }
            ~Temp() { num++; }
        }
        
        //Inheritance Example
        class Animal
        {
            public int Legs { get; set; }
            public int Age { get; set; }
        }
        class Dog : Animal
        {
            public Dog()
            {
                Legs = 4; 
            }

            public int speed { get; set; }

            public void Bark()
            {
                Console.WriteLine("Woof");
            }
        }
        class Poodle : Dog
        {
            public Poodle()
            {
                speed = 5;
            }
        }

        static void Main(string[] args)
        {
            Temp t = new Temp();
            Console.WriteLine(t.num);
            Console.ReadLine();

            Dog d = new Dog();
            Console.WriteLine(d.Legs);
            // Outputs 4

            d.Bark();
            //Outputs "Woof"

            Poodle fluffy = new Poodle();
            Console.WriteLine(fluffy.speed);
            Console.ReadLine();
        }
    }
}
