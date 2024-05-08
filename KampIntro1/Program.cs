using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ne yazıyorsa o değeri tutuyor (tersini değil karıştırma!!!)
            bool sistemegirisyapmismi = true;
            if (sistemegirisyapmismi)
            {
                Console.WriteLine("yapmış");
            }


            else
            {
                Console.WriteLine("yapmamış");
            }



            double dolardun  = 32.38;
            double dolarbugun = 32.50;
            if (dolardun>dolarbugun)
            {
                Console.WriteLine("düşmüş");
            }

            else if (dolardun<dolarbugun)
            {
                Console.WriteLine("artmış");
            }

            else
            {
                Console.WriteLine("eşit kalmış");
            }
        }
    }
}
