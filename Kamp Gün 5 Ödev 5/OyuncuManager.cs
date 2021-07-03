using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp_Gün_5_Ödev_5
{
    class OyuncuManager:Oyuncu
    {
        List<String> kimlikNos = new List<string>();
        List<String> isimler = new List<string>();
        List<String> soyIsimler = new List<string>();
        List<String> dogumTarihleri = new List<string>();

        public void KayitOl(Oyuncu oyuncu)
        {
            kimlikNos.Add(oyuncu.TcNo);
            isimler.Add(oyuncu.Ad);
            soyIsimler.Add(oyuncu.Soyad);
            dogumTarihleri.Add(oyuncu.DogumYili);
        }

        public void KaydiSil(Oyuncu oyuncu)
        {
            Console.WriteLine("Kayıt silindi...");
        }

        public void KaydiGuncelle(Oyuncu oyuncu)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
