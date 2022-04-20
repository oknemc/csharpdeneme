using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {

        //naming convention - kod okunurluğu
        // syntax - kod dillerinin yazım şekilleri örn; c# cw java system.out.println vs.
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepeete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }
    }
}
