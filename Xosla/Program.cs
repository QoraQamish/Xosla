using DirectoryClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xosla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birxadli funksiya kiriting");
            Console.Write("koyefsentini kiting >> ");
            double koy = double.Parse(Console.ReadLine());

            Console.Write("argumentini kiting >> ");
            string argument = Console.ReadLine();

            Console.Write("darajasini kiting >> ");
            double daraja = double.Parse(Console.ReadLine());

            Console.Write("necha marta hosila olasiz >> ");
            double n = double.Parse(Console.ReadLine());

            KO_PHAD ob = new KO_PHAD();
            ob.hisobla(koy, argument, daraja, n);
        }
    }
}
