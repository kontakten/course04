using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus04d
{
    class Program
    {
        static void Main(string[] args)
        {
            IDBFunktioner[] arr = new IDBFunktioner[4];

            arr[0] = new Hund();
            arr[1] = new Ubåd();
            arr[2] = new Hund();
            arr[3] = new Ubåd();

            foreach (IDBFunktioner item in arr)
            {
                item.Gem();
            }

            Console.ReadLine();


            Hund h = new Hund();
            Ubåd u = new Ubåd();

            IDBFunktioner idb = h;

            IDBFunktioner idb2 = u;

            gemDims(idb);

            gemDims(idb2);

            List<IDBFunktioner> idbList = new List<IDBFunktioner>();

            idbList.Add(new Hund { Navn = "Valter" });

            idbList.Add(new Ubåd { Nummer = 1337, Tubine = 2.2 });

            idbList.Add(new Hund { Navn = "Guffy" });

            foreach (IDBFunktioner item in idbList)
            {
                item.Gem();
            }


            Console.ReadLine();
        }

        static void gemDims(IDBFunktioner idbFunk)
        {
            idbFunk.Gem();
        }
    }

    class Hund : IDBFunktioner
    {
        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer Hund");
        }
    }

    class Ubåd : IDBFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer Ubåd");
        }
    }
    

    interface IDBFunktioner
    {
        void Gem();
    }



    interface IMaskine
    {
        void Start();
        void Stop();
    }

    class Maskine : IMaskine
    {
        public void Start()
        {
        }

        public void Stop()
        {
        }
    }
}
