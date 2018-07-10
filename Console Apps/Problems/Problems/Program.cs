using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class Program
    {
        //Problem 3: Write a function to print the first letter of every word in a string.
        
            static public void firstLetterFinder(string sentence)
            {
                string[] words = sentence.Split(' ');

                foreach (var word in words)
                {
                    Console.WriteLine(word[0]);
                }
            }
        static void Main(string[] args)
        {
            
            string[] words = { "The", "quick", "brown", "fox", "jumped", "over", "the", "lazy", "dog." };

            var unreadablePhrase = string.Concat(words);
            Console.WriteLine(unreadablePhrase);

            var readablePhrase = string.Join(" ", words);
            Console.WriteLine(readablePhrase);
            
            /*Problem 3
            string sentence = "Hey, my name is Bob.";

            firstLetterFinder(sentence);
            */

            /* PROBLEM 1: Sum up all even numbers in array
            int[] numbers = { 1,2,3,4,5,6};
            int sum = 0;
            foreach(int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine(sum);
            */

            /*Problem 2: Determine if a word is a palindrome
            //string notPalindrome = "notPalindrome";
            string palindrome = "racecar";

            for(int i=0; i<palindrome.Length/2; i++)
            {
                if(palindrome[i] == palindrome[palindrome.Length-1-i])
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            */



            Console.ReadLine();
        }
    }
}
