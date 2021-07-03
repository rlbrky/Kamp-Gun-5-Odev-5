using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp_Gün_5_Ödev_5
{
    class OyunManager
    {
        public string Ad { get; set; }
        public int Fiyat { get; set; }

        public void SatisYap(Oyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Ad+"'a " + this.Ad + " Satıldı."); 
        }
    }
}
