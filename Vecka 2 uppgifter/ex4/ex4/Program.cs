using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
       public static void Main(string[] args)
        {
            // generate a random color
            var random = new Random();
            while (true) 
            {
                var color = (ConsoleColor)random.Next(1, 16);
               
                int windowWidth = Console.WindowWidth;
                int windowHeight = Console.WindowHeight;
                
                int BlockWidth = random.Next(0, windowWidth); 
                int BlockHeight = random.Next(0, windowHeight);
                // draw something with it on position 10, 5
                Console.BackgroundColor = color;
                
               
                int startPosX = random.Next(0,windowHeight);
                int startPosY = random.Next(0,windowWidth);
                for(int i = 0; i< BlockHeight; i++) 
                {
                    string str = "";
                    
                    for (int j = 0; j < BlockWidth; j++)
                    {
                       
                        str += " ";
                        
                    }
                    Console.SetCursorPosition(startPosY, startPosX + i);
                    Console.WriteLine(str);

                
                }
                System.Threading.Thread.Sleep(100);




            }
            
        }

    }
}
