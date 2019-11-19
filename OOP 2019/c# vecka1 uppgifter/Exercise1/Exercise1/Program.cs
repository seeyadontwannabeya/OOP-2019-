using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = ReadInt("Type a number: "); 
            int y = ReadInt("Type another number: "); 

            Console.WriteLine();
            Console.WriteLine($"{x} + {y} = {x + y}");

            Console.ReadLine();
        }


        static int ReadInt(string message)
        {
            int number = 0;
            bool success = false;


            while (success == false)
            {
                Console.WriteLine(message);

                try
                {

                    number = int.Parse(Console.ReadLine());
                    success = true;
                }
                catch (Exception e)
                {

                    Console.WriteLine("That's not a number, try again", e);

                }
            }

            return number;
        }




    }
}
