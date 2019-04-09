 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();
            //Motorcycle moto;
            moto.Name = "Honda";
            var type = moto.GetType();


            Console.WriteLine(moto.GetHashCode());
            Console.WriteLine(moto.GetType());

            Console.ReadLine();
        }
    }
    struct Motorcycle
    {
        public string Name { get; set; }
    }
}
