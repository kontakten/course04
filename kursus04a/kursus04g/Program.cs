using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus04g
{
    public delegate int Beregn(int a, int b);

    public delegate string Print(string txt);

    class Program
    {
        static void Main(string[] args)
        {

            Beregn add = new Beregn(Plus);

            Beregn remove = new Beregn(Minus);

            int resultat = Beregner(1, 2, add);

            resultat = Beregner(6, 3, remove);

            var test = FindTilfældigFunktion();

            int resultatNy = test(5, 20);

            Console.WriteLine($"Resultatet er: {resultat}");

            Console.WriteLine();

            Console.WriteLine($"Nyt resultat er: {resultatNy}");

            Console.ReadLine();

            var nyDelStringPrint = Udskriv();

            string skrivResultat = nyDelStringPrint("Jeg er så glad idag");

            Console.WriteLine(skrivResultat);

            Console.ReadLine();

            Print p = ErGladStr;

            p += ErGladStr;

            p("Jeg er meget glad");

            Console.ReadLine();


            Action d1 = ErGladStrVoid;
            d1();

            Action<int, int> d2 = PlusEmulator;
            d2(10, 20);

        }

        public static void PlusEmulator(int a, int b)
        {

        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }
        public static int Beregner(int a, int b, Beregn c)
        {
            return c(a, b);
        }
        public static Beregn FindTilfældigFunktion()
        {
            if (System.DateTime.Now.Millisecond <= 250)
                return Plus;
            if (System.DateTime.Now.Millisecond <= 500)
                return Minus;
            if (System.DateTime.Now.Millisecond <= 750)
                return Gange;

            return Divider;

        }

        public static string ErGladStr(string txt)
        {
            Console.WriteLine(txt);
            return txt;
        }
        public static void ErGladStrVoid()
        {
            Console.WriteLine("Kaldet fra Action");
        }
        public static Print Udskriv()
        {
            return ErGladStr;
        }
    }
}
