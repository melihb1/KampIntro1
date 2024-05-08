using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classİntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Kursadi = "C#";
            kurs1.KursEgitmeni = "Canan Yılmaz";
            kurs1.IzlenmeOrani = 100;

            Kurs kurs2 = new Kurs();
            kurs2.Kursadi = "C++";
            kurs2.KursEgitmeni = "Gürcan Yılmaz";
            kurs2.IzlenmeOrani = 99;


            Kurs kurs3 = new Kurs();
            kurs3.Kursadi = "Java";
            kurs3.KursEgitmeni = "Hakan Kandemir";
            kurs3.IzlenmeOrani = 101;

            Console.WriteLine(kurs1.KursEgitmeni+"  :  "+kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach ( var kurs in kurslar)
            {
                Console.WriteLine(kurs.Kursadi);
            }

        }
    }

    class Kurs
    {
        public string Kursadi { get; set; }
        public string KursEgitmeni { get; set; }
        public int  IzlenmeOrani { get; set; }
    }
}
