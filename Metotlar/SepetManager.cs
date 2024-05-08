using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
         public void Add(Urun urun)
            //metot //public void Add(Urun urun) bu parametre
 //public void Add2(string urunAdı, string Acıklaması,int Fıyatı) böyle yazma!!! kapsülleme olmaz
        {
            Console.WriteLine("Bizimle  Alışveriş Yaptığınız İçin Teşekkürler,Sepetinize Eklendi!!!"+urun.Adi);
        }
        public void Add2(string urunAdı, string Acıklaması,int Fıyatı)
        {
            Console.WriteLine("Bizimle  Alışveriş Yaptığınız İçin Teşekkürler, Sepetinize Eklendi!!!"+urunAdı);


        }
    }
}
