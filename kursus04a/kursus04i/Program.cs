using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus04i
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.FileSystemWatcher fsw = new System.IO.FileSystemWatcher(@"C:\repo", "*.txt");

            fsw.EnableRaisingEvents = true;

            fsw.Changed += IsChanged;

            do
            {

            } while (true);
        }
        static void IsChanged (object o, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Changed" + e.Name);
        }
    }
}
