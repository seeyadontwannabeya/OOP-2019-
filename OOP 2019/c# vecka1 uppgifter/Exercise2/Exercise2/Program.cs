using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int minYear = 0;
            int firstYear = GetYear("First year: ", minYear); 
            minYear = firstYear; 
            int secondYear = GetYear("Second year: ", minYear);
            LeapYearCalculator(firstYear, secondYear);
            Console.ReadLine();
        }

        static int GetYear(string message, int minYear)
        {
            int year = 0;

            while (year <= minYear && year < 9999)
            {
                year = ReadInt(message);
                message = "Year must be between 0 and 9999.";
            }
           
            
            return year;
        }
        static void LeapYearCalculator(int firstYear, int secondYear)
        {
            int x ; 

            for (int i = firstYear; i <= secondYear; i++)
            {
                var leapyear = DateTime.IsLeapYear(i);
             
                if (leapyear)
                {
                    Console.WriteLine(i+"*");
                }
                else
                { 
                    Console.WriteLine(i);
                }
               
            }
   
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
                    
                    message = "input must be a number, try again";

                }
            }

            return number;
        }

    }
}
