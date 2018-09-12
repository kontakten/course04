using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus04c
{
    class Program
    {
        static void Main(string[] args)
        {
            Kursist k = new Kursist() { Id = 1, Navn = "Mikkel" };
            Person p = new Kursist() { Id = 2, Navn = "Nicki" };
            k.Skriv1();
            k.Skriv2();

            p.Skriv1();
            p.Skriv2();

            Console.ReadLine();

            A a = new A();
            B b = new B();
            A c = new B();

            Console.ReadLine();
        }

    }

    abstract class Person
    {
        public int Id { get; set; }

        public string Navn { get; set; }

        public void Skriv1()
        {
            Console.WriteLine($"Person med id {Id} og navn {Navn}");
        }

        public abstract void Skriv2();

    }
    class Kursist : Person
    {
        public override void Skriv2()
        {
            Console.WriteLine($"Kursist med id {Id} og navn {Navn}");
        }
    }

    /// <summary>
    /// Sealed class rule - 
    /// </summary>

    class A
    {
        public virtual void Test()
        {
            Console.WriteLine("I A");
        }
    }

    class B : A
    {
        public new void Test()
        {
            Console.WriteLine("I B");
        }
    }

    sealed class C : B
    {
        public new void Test()
        {
            Console.WriteLine("I C");
        }
    }

    //class D : C // class C is sealed !
    //{

    //}
}
