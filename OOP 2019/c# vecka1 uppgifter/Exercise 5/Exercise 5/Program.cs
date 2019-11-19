using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var random = new Random();
            var number = random.Next(1,99 );
            int myGuess;
            bool run = false;

            while (!run)
            {
              
                    Console.WriteLine("Guess a number: ");
                    myGuess = Convert.ToInt32(Console.ReadLine());

                    if (myGuess == number){
                        Console.WriteLine("that is correct");
                    }
                    else if (myGuess > number)
                    {
                        Console.WriteLine("too high");
                    }
                    else if( myGuess < number)
                    {
                        Console.WriteLine("too low");
                    }
                
            }



        }
    }
}
