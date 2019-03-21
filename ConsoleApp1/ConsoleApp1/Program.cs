using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] array = new object[3];
            array[0] = 32;
            array[1] = 'A';
            string s1 = "Hello";
            array[2] = s1;
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);


            Console.ReadLine();
        
    }
    }
}
