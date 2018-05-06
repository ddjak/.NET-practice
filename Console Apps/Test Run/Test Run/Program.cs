using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Run
{
    class Program
    {
        class Person
        {
            int age;
            string name;
            public void sayHi()
            {
                Console.WriteLine("Hey there");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        int sum(int num1, int num2) {
            return num1 + num2;
        }
            Console.WriteLine(sum(2, 3));

            Person frank = new Person();
            frank.sayHi();

            Console.ReadLine();
        }
    }
}
