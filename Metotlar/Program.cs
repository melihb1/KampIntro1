using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1= new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 10;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 100;
            urun2.Aciklama = "Diyarbakır Karpuzu";


            Urun[] urunler = new Urun[] { urun1, urun2, };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi+" : "+urun.Fiyati);

            }
            Console.WriteLine("--------------Metotlar------------------");

            SepetManager speetManager = new SepetManager(); //class örneği
            speetManager.Add(urun1);
            speetManager.Add(urun2);


            Console.WriteLine("************");


            speetManager.Add2("Elma", "Yesil Elma", 29);
            speetManager.Add2("Armut", "Yesil Armut", 40);
            speetManager.Add2("Karpuz", "Yesil Karpuz", 100);



        }
    }
}
