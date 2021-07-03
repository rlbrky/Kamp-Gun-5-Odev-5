using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp_Gün_5_Ödev_5
{
    class KampanyaManager
    {
        public void AddKampanya(OyunManager oyun)
        {
            Console.WriteLine(oyun.Ad+"'ya Kampanya Yapıldı.");
            Console.WriteLine("Yeni fiyat: "+oyun.Fiyat/2);
        }

        public void RemoveKampanya()
        {
            Console.WriteLine("Kampanya Bitti.");

        }

        public void UpdateKampanya(OyunManager oyun)
        {
            Console.WriteLine(oyun.Ad+"'ya Kampanya Güncellendi.");
            Console.WriteLine("Yeni fiyat: "+oyun.Fiyat/4);
        }
    }
}
