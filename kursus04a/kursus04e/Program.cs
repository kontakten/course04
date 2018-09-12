using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus04e
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Terning t = new Terning(new TilfældighedsGeneratorFramework());
                t.Skriv();
            }

            Console.ReadLine();
        }
    }
    class Terning
    {
        private ITilfældighedsgenerator rnd;


        public int Værdi { get; set; }

        public void Ryst()
        {
            Værdi = rnd.FindTal(1, 7);
        }
        public void Skriv()
        {
            Console.WriteLine($"{Værdi}");
        }
        public Terning(ITilfældighedsgenerator gen)
        {
            this.rnd = gen;
            Ryst();
        }
    }
    interface ITilfældighedsgenerator
    {
        int FindTal(int min, int max);
    }

    class TilfældighedsGeneratorFramework : ITilfældighedsgenerator
    {
        private static System.Random rnd = new Random();
        public int FindTal(int min, int max)
        {
            return rnd.Next(1, 7);
        }
    }
    class TilfældighedsGeneratorMock : ITilfældighedsgenerator
    {
        public int FindTal(int min, int max)
        {
            return min;
        }
    }

}