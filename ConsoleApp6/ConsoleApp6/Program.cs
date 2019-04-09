using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            var moto = new
            {
                Name = "Honda",
                Year = 2004,
                Odometer = 35000
            };

            Console.WriteLine(moto);
            Console.WriteLine($"N - {moto.Name} {moto.Odometer} {moto.Year}");
            Console.WriteLine(moto.GetType());

            Console.ReadLine();
        }
    }
}
