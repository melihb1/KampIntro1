using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"1.kurs","2.kurs","3.kurs" };

            for (int i = 0; i<kurslar.Length; i++) //lenght dizinin eleman sayısı kadar anlamına gelir
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("alta geçti for döbgüsü bitti");


            foreach (string s in kurslar) //dizilere uygulanır
            {
                Console.WriteLine(s);
            }
        }
    }
}
