using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var color = random.Next(8, 16);
            Console.BackgroundColor = (ConsoleColor)color;


            //Console.WindowHeight(1,1);
            //Console.WindowWidth();
            Console.SetCursorPosition(1, 1);
            //Console.BackgroundColor = color;

            for(int i =0; i <= 50; i++)
            {
                //for(int y = 0; y < i; y++)
                { 
                    Console.Write(" "); 
                }
                Console.Write(i + "/50");
                Console.SetCursorPosition(1, 1);
                
            }

            Console.ReadLine();



        }
    }
}
