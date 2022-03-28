using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobile s = new Mobile("Samsung", "Galaxy  S20", "mobile phone", "12.03.2022");
            s.Print();
            Landline c = new Landline("Panasonic", "KX-TS2350","84953622736");
            c.Print();
            Console.ReadKey();
        }
    }
}
