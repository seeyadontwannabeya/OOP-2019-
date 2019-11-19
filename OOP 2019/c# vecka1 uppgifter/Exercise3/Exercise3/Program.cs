using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a word: ");
            string word = Console.ReadLine();
            Console.Write(IsPalindrome(word));
            Console.ReadLine();
        }

       public static bool IsPalindrome(string words)
        {
            bool palin = false;
            words = words.Replace(" ", "").ToLower();
            string wordBackwards = "";

            for(int i = words.Length - 1; i >= 0; i--)
            {     
                wordBackwards += words[i];
            }

            if (words == wordBackwards)
            {
                palin = true;
            }  
            return palin;
        }
    }
}
