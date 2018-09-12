using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus04f
{
    public delegate void MinDelegate1();
    public delegate int MinDelegate2(int i);
    public delegate int MinDelegate3(int i, int y);
    public delegate void MinDelegate4(string txt);

    class Program
    {
        static void Main(string[] args)
        {
            //Metode1();
                      // \/ func pointer object\\
            MinDelegate1 f1 = new MinDelegate1(Metode1); // f1 = object which is referencing to Metode1.

            f1.Invoke();
            
            MinDelegate4 l1 = Metode2; // Reference to Metode2;
            l1 += Metode3;
            l1 += LogTilFil;

            l1.Invoke("World");

            Console.ReadLine();
        }

        public static void Metode1()
        {
            Console.WriteLine("I metode1");
        }
        public static void Metode2(string t)
        {
            Console.WriteLine("Hello " + t + " from Metode2");
        }
        public static void Metode3(string t)
        {
            Console.WriteLine("Hello " + t + " from Metode3");
        }
        public static void LogTilFil(string t)
        {
            System.IO.File.AppendAllText(@"C:\repo\log.txt", t);
            //Console.WriteLine("Hello " + t + " from Metode3");
        }
    }

    class Person
    {

    }

    class Kursist : Person
    {

    }
}
