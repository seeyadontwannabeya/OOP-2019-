using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class BoxManager
    {
        public List<Box> boxes = new List<Box>();
        public void DrawInCenter()
        {
            var height = Console.WindowHeight; 
            var width = Console.WindowWidth; 

            
            int startHeight = height / 2;
            int startWidth = width / 2;

            


            Console.Write(width);

           
            foreach (var box in boxes) 
            {
                int boxWidth = box.width / 2;
                int boxHeight = box.height / 2;

                box.Draw(startWidth - boxWidth ,startHeight - boxHeight); 
            }
        
        }
    }
    
}

