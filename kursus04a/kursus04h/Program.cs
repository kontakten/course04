using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus04h
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lambda expression !

            int[] tal = { 10, 20, 5, 13, 17, 44, 32, 75 };

            var result = System.Array.FindAll(tal, i => i > 50);

            Console.ReadLine();
        }

        public static void TesT()
        {
            Console.WriteLine("Hello World Lambda");
        }
    }
}
