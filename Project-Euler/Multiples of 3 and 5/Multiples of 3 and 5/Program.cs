using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_of_3_and_5
{
    class Program
    {
        public static int SumUp(int numbersInArray)
            {
                int[] numbers = new int[numbersInArray];
                for (int i = 0; i < numbersInArray; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        numbers[i] = i;
                    }
                }
                return numbers.Sum();
            }

        static void Main(string[] args)
        {
            int total = 1000;           

            Console.WriteLine(SumUp(total));

            Console.ReadLine();
        }
    }
}
