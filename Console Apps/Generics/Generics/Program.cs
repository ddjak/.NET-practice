using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {   static void Swap<T>(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }

        static void Main(string[] args)
        {
            int a = 4, b = 5;
            Swap<int>(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);


            List<string> L = new List<string>();
            L.Add("1st");

            Queue<string> FIFO = new Queue<string>(L);
            FIFO.Enqueue("2nd");
            FIFO.Enqueue("3rd");
            FIFO.Enqueue("4th");
            FIFO.Enqueue("5th");
            FIFO.Enqueue("6th");
            Console.WriteLine("------------");
            foreach (string s in FIFO)
            {
                
                Console.WriteLine(s);
            }

            FIFO.Dequeue();
            FIFO.Dequeue();
            Console.WriteLine("-------------------");
            foreach (string s in FIFO)
            {
                
                Console.WriteLine(s);
            }

            Stack<string> stack = new Stack<string>();
            stack.Push("Push 1");
            stack.Push("Push 2");
            stack.Pop();
            Console.WriteLine("-------------");
            foreach (string i in stack)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
