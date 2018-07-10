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

            public virtual void Call()
            {
                Console.WriteLine("This is a call: ");
            }
        }
        class Dog : Animal
        {
            public Dog()
            {
                Legs = 4; 
            }

            public int speed { get; set; }

            public override void Call()
            {
                Console.WriteLine("BARK");
            }

            
        }
        class Poodle : Dog
        {
            public Poodle()
            {
                speed = 5;
            }
        }
        struct Book
        {
            public string title;
            public double price;
            public string author;
        }

        static void Main(string[] args)
        {

            Temp t = new Temp();
            Console.WriteLine(t.num);
            Console.ReadLine();

            Animal d = new Dog();
            Console.WriteLine(d.Legs);
            // Outputs 4

            d.Call();
            //d.Bark();
            //Outputs "Woof"

            Poodle fluffy = new Poodle();
            Console.WriteLine(fluffy.speed);

            Console.WriteLine("--------------------------");

            Book b;
            b.title = "Book Title";

            Console.WriteLine(b.title);

            Console.ReadLine();
        }
    }
}
