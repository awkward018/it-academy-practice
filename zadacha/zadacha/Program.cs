using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    class Programsqares
    {
        static void Main(string[] args)
        {
            int k = 0; //k is counter
            Rectangle[] sqares = new Rectangle[100];
            Random rand = new Random();
            for (int i=0;i<100;i++)
            {
                sqares[i].Height = rand.Next(1, 10);
                sqares[i].Width = sqares[i].Height;
                Console.WriteLine(sqares[i].Height);
            }
            Rectangle rectangle = sqares[0];
            for (int i=1;i<100;i++)
            {
                if (rectangle.Equals(sqares[i]))
                    k++;
            }
            Console.WriteLine("Equals sqares: ");
            Console.WriteLine(k);
            Console.ReadLine();
        }  
    struct Rectangle
        {
            public int Height { get; set; }
            public int Width { get; set; }
        }

}

 
    
        
        
    
}
