using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World who are you?");
            var name = Console.ReadLine();
            String Namex2 = name + name;
            string names = Namex2;

            Console.WriteLine(name + ".."+ Namex2 + ".." +names);
        }
    }
}
