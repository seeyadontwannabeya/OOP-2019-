using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two boxes
            ////var box1 = new Box();
            ////var box2 = new Box();

            ////// set some values on them
            ////box1.x = 3;
            ////box1.y = 2;
            ////box1.width = 7;
            ////box1.height = 4;

            ////box1.color = ConsoleColor.Red;
            ////box2.color = ConsoleColor.Blue;


            ////box2.x = 17;
            ////box2.y = 4;
            ////box2.width = 13;
            ////box2.height = 8;

            ////// draw both on the screen
            ////box1.Draw(3);
            ////box2.Draw(15);
            ///
           
            ///// create a new manager with an empty list
            var manager = new BoxManager()
            {
                boxes = new List<Box>()
            };

            // add a box to the list
            manager.boxes.Add(new Box()
            {
                height = 10,
                width = 20,
                color = ConsoleColor.Red,
            });

            // and another one
            manager.boxes.Add(new Box() 
            {
                height = 6,
                width = 12,
                color = ConsoleColor.Blue,
            });

            // tell the manager to center and draw all boxes
            manager.DrawInCenter();
            Console.ReadKey();
        }

        
    }
    public class Box
    { 
        public int x;
        public int y;
        public int width;
        public int height;
        public ConsoleColor color;

        public void Draw(int startposX, int startposY)
        {
            Console.ForegroundColor = color;
            for(int i = 0;i < height;i++)
            {
                string str = "";
                for(int j=0; j < width; j++)
                {
                    str += "X";
                }
                Console.SetCursorPosition(startposX, startposY + i); 
                Console.WriteLine(str);  
            }

           
            

        }
        

    }
}
