using System;

namespace Kamp_Gün_5_Ödev_5
{
    class Program
    {
        static void Main(string[] args)
        {
            OyunManager oyunManager = new OyunManager { Ad = "LOL", Fiyat = 50 };
            Oyuncu oyuncu1 = new Oyuncu { Ad = "Berkay", Soyad = "Erol", TcNo = "12312312412", DogumYili = "1900" };
            OyuncuManager oyuncuManager = new OyuncuManager();
            KampanyaManager kampanyaManager = new KampanyaManager();

            oyuncuManager.KayitOl(oyuncu1);
            oyuncuManager.KaydiGuncelle(oyuncu1);
            oyuncuManager.KaydiSil(oyuncu1);

            oyunManager.SatisYap(oyuncu1);

            kampanyaManager.AddKampanya(oyunManager);
            kampanyaManager.UpdateKampanya(oyunManager);
            kampanyaManager.RemoveKampanya();
        }
    }
}
