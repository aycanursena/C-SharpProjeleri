using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    internal class Metotlar
    {
        public void IslemMenusu() 
        {
            Console.WriteLine("İşlem yapmak istediğiniz geometrik şekli seçiniz.." +
                "\n1-Daire\n2-Üçgen\n3-Kare\n4-Dikdörtgen\n0-Çıkış Yap");
            Console.Write("Seçiminiz : ");
            int secilenSekil = Convert.ToInt32(Console.ReadLine());
            Hesaplama(secilenSekil);
        }
        public void Hesaplama(int secilenSekil)
        {
            while (secilenSekil != 0)
            {
                switch (secilenSekil)
                {
                    case 1:
                        BoyutBelirle(secilenSekil);
                        break;
                    case 2:
                        BoyutBelirle(secilenSekil);
                        break;
                    case 3:
                        BoyutBelirle(secilenSekil);
                        break;
                    case 4:
                        BoyutBelirle(secilenSekil);
                        break;
                }
            }
            Console.WriteLine("--- PROGRAM SONLANDIRILDI !! ---");
        }
  
        public void BoyutBelirle(int secilenSekil)
        {
            Console.WriteLine();
            Console.WriteLine("Hesaplamak istediğiniz boyutu seçiniz :" +
                "\n1-Çevre\n2-Alan\n3-Hacim\n0-Çıkış Yap");
            Console.Write("Seçiminiz : ");
            int secilenBoyut = Convert.ToInt32(Console.ReadLine());
            Hesap(secilenSekil, secilenBoyut);
        }
        public void Hesap(int secilenSekil, int secilenBoyut)
        {
            while (secilenBoyut != 0)
            {
                switch (secilenBoyut)
                {
                    case 1:
                        if (secilenSekil == 1)
                        {
                            Console.Write("Yarıçap giriniz : ");
                            int yarıcap = Convert.ToInt32(Console.ReadLine());
                            double daireCevre = 2 * Math.PI * yarıcap;
                            Console.WriteLine("Dairenin çevresi : " + daireCevre);
                            BoyutBelirle(secilenSekil);
                        }
                        else if (secilenSekil == 2)
                        {
                            Console.Write("Üçgenin üç kenar uzunluk bilgisini aralarında virgül olacak şekilde giriniz : ");
                            string ucgenKenar = Console.ReadLine();
                            string[] kenarUzunlukları = ucgenKenar.Split(',');
                            int toplam = 0;
                            foreach (var item in kenarUzunlukları)
                            {
                                toplam += int.Parse(item) * 2;
                            }
                            Console.WriteLine("Üçgenin çevresi : " + toplam);
                            BoyutBelirle(secilenSekil);
                        }
                        else if (secilenSekil == 3)
                        {
                            Console.Write("Kenar uzunluğunu giriniz : ");
                            int kenar = Convert.ToInt32(Console.ReadLine());
                            int toplam = kenar * 4;
                            Console.Write("Karenin çevresi : " + toplam);
                            BoyutBelirle(secilenSekil);
                        }
                        else if (secilenSekil == 4)
                        {
                            Console.Write("Kısa kenar uzunluğunu giriniz : ");
                            int kisa = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Uzun kenar uzunluğunu giriniz : ");
                            int uzun = Convert.ToInt32(Console.ReadLine());
                            int toplam = kisa * 2 + uzun * 2;
                            Console.WriteLine("Dikdörtgenin çevresi : " + toplam);
                            BoyutBelirle(secilenSekil);
                        }
                        break;
                    case 2:
                        if(secilenSekil == 1)
                        {
                            Console.Write("Yarıçap : ");
                            int yaricap = Convert.ToInt32(Console.ReadLine());
                            double alan = Math.PI * yaricap * yaricap;
                            Console.WriteLine("Dairenin alanı : " + alan);
                            BoyutBelirle(secilenSekil);
                        } 
                        else if(secilenSekil == 2) 
                        {
                            Console.Write("Yükseklik : ");
                            int yukseklik = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Taban uzunluğu : ");
                            int tabanUz = Convert.ToInt32(Console.ReadLine());
                            int alan = (tabanUz * yukseklik) / 2;
                            Console.WriteLine("Üçgenin alanı : " + alan);
                            BoyutBelirle(secilenSekil);
                        }
                        else if (secilenSekil == 3)
                        {
                            Console.Write("Kenar uzunluğu : ");
                            int kenar = Convert.ToInt32(Console.ReadLine());
                            double alan = Math.Pow(kenar, 2);
                            Console.WriteLine("Karenin alanı : " + alan);
                            BoyutBelirle(secilenSekil);
                        } 
                        else if (secilenSekil == 4)
                        {
                            Console.Write("Kısa kenar: ");
                            int kısa = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Uzun kenar : ");
                            int uzun = Convert.ToInt32(Console.ReadLine());
                            int alan = kısa * uzun;
                            Console.WriteLine("Dikdörtgenin alanı : " + alan);
                            BoyutBelirle(secilenSekil);
                        }
                        break;
                    case 3:
                        if(secilenSekil == 1)
                        {
                            Console.Write("Yarıçap : ");
                            int yaricap = Convert.ToInt32(Console.ReadLine());
                            double hacim = (4 / 3) * Math.PI * Math.Pow(yaricap , 3);
                            Console.WriteLine("Kürenin hacmi : " + hacim);
                            BoyutBelirle(secilenSekil);
                        }
                        else if (secilenSekil == 2)
                        {
                            Console.Write("Kenar uzunluğu : ");
                            int kenar = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Yükseklik : ");
                            int yukseklik = Convert.ToInt32(Console.ReadLine());
                            double hacim = (((kenar * kenar) * Math.Sqrt(3)) / 4) * yukseklik;
                            Console.WriteLine("Üçgenin hacmi : " + hacim);
                            BoyutBelirle(secilenSekil);
                        } 
                        else if (secilenSekil == 3)
                        {
                            Console.Write("Kenar uzunluğu : ");
                            int kenar = Convert.ToInt32(Console.ReadLine());
                            double hacim = Math.Pow(kenar, 3);
                            Console.WriteLine("Küpün hacmi : " + hacim);
                            BoyutBelirle(secilenSekil);
                        } 
                        else if (secilenSekil == 4)
                        {
                            Console.Write("Kısa kenar : ");
                            int kısa = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Uzun kenar : ");
                            int uzun = Convert.ToInt32(Console.ReadLine());
                            double hacim = kısa * uzun * kısa;
                            Console.WriteLine("Dikdörtgenin hacmi : " + hacim);
                            BoyutBelirle(secilenSekil);
                        }
                        break;
                }
            }
            Console.WriteLine("\nÇıkış Yapıldı...");
            IslemMenusu();
        }
    }
}
