using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryClass
{
    public class KO_PHAD
    {
        public void hisobla(string argument, double darajasi, double n)
        {
            double koy = 1;
            if (n < darajasi)
            {
                for (int i = 0; i < n; i++)
                {
                    koy *= darajasi;
                    darajasi -= 1;
                }
                Console.WriteLine($"{koy}{argument}^{darajasi}");
            }
            else if (n == darajasi)
            {
                for (int i = 0; i < n; i++)
                {
                    koy *= darajasi;
                    darajasi -= 1;
                }
                Console.WriteLine($"{koy}");
            }
            else if (n > darajasi)
                Console.WriteLine("0");
        }
        public void hisobla(double koyefsent, string argument, double darajasi, double n)
        {
            if (n < darajasi)
            {
                for (int i = 0; i < n; i++)
                {
                    koyefsent *= darajasi;
                    darajasi -= 1;
                }
                Console.WriteLine($"{koyefsent}{argument}^{darajasi}");
            }
            else if (n == darajasi)
            {
                for (int i = 0; i < n; i++)
                {
                    koyefsent *= darajasi;
                    darajasi -= 1;
                }
                Console.WriteLine($"{koyefsent}");
            }
            else if (n > darajasi)
                Console.WriteLine("0");
        }
    }
}
