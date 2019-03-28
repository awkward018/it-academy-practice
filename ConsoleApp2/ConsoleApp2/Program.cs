using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello, Guys!");
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.MaxCapacity);

            sb.Append("\nHello");
            Console.WriteLine($"{sb.Length}---{sb.Capacity}");

      




            Console.ReadLine();
        }
    }
}
