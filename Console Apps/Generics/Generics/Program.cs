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
            //Console.WriteLine(a);
            //Console.WriteLine(b);


            var list = new List<int>    
            {
                1, 2, 3, 4, 5
            };
            /*
            foreach(var number in list)
            {
                Console.WriteLine(number);
            }
            */
            list.Add(6);

            Console.WriteLine("Print: " + list[5].ToString());

            //Console.WriteLine(list);
            /*
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
            }*/

            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();

            var q = new Queue<int>();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Dequeue();

            Console.WriteLine("QUEUE: ");
            foreach (var number in q)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("STACK: ");
            foreach (var number in stack)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
