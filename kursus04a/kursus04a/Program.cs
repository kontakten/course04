using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus04a
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.test();
            B b = new B();
            b.test();

            A c = new B(); // B is A.
                           //c.test2(); -- not test3

            (c as B).test3(); // possible

            Console.ReadLine();
        }
    }
    class A
    {
        public virtual void test() {
            Console.WriteLine("I A");
        }
        public void test2()
        {

        }
    }

    class B : A
    {
        public override void test()
        {
            Console.WriteLine("I B");
        }
        public void test3()
        {

        }
    }
}
