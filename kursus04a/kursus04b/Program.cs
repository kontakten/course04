using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus04b
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dyr> lst = new List<Dyr> { new Kat(), new Hund(), new Kat(), new Dyr(), new Kat(), new Hund() };

            foreach (var item in lst)
            {
                item.SigNoget();
            }

            Console.ReadLine();


            Dyr[] dyr = new Dyr[20];
            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }

            foreach (var item in dyr)
            {
                item.SigNoget();
            }
            Console.ReadLine();
        }
    }

    class Dyr
    {
        static string sti = @"C:\Repo\course04\kursus04a\kursus04b\dyrenavne.txt";

        static Random rnd = new Random();

        public string Navn { get; set; }
                     
        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr");
        }
        public static Dyr TilfældigtDyr()
        {
            string[] navne = System.IO.File.ReadAllLines(sti);

            int index = rnd.Next(0, navne.Length);

            if(index % 2 == 0)
            {
                return new Hund() { Navn = navne[index] };
            }
            else
            {
                return new Kat() { Navn = navne[index] };
            }
        }
    }
    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en Hund, og jeg hedder {Navn}");
        }
    }
    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en kat, og jeg hedder {Navn}");
            
        }
    }
}
