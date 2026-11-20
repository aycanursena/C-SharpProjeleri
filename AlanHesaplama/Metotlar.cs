using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    internal class Metotlar
    {
        // Kullanıcıya geometrik şekil seçenekleri sunularak işlem menüsüne erişim sağlanmaktadır.
        public void IslemMenusu() 
        {
            // Geometrik şekil seçenekleri ekrana yazdırılmaktadır.
            Console.WriteLine("İşlem yapmak istediğiniz geometrik şekli seçiniz.." +
                "\n1-Daire\n2-Üçgen\n3-Kare\n4-Dikdörtgen\n0-Çıkış Yap");

            // Kullanıcının geometrik şekil seçimi alınmaktadır.
            Console.Write("Seçiminiz : ");
            int secilenSekil = Convert.ToInt32(Console.ReadLine());

            // Seçilen geometrik şekle göre ilgili işlem başlatılmaktadır.
            Hesaplama(secilenSekil);
        }

        // Seçilen geometrik şekle göre hesaplama sürecinin yönlendirilmesi sağlanmaktadır.
        public void Hesaplama(int secilenSekil)
        {
            // Kullanıcının çıkış seçeneğini tercih etmesine kadar işlem akışı sürdürülmektedir.
            while (secilenSekil != 0)
            {
                // Seçilen şekle uygun boyut belirleme metodu çağrılmaktadır.
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

            // Programın sonlandırıldığı bilgisi kullanıcıya bildirilmektedir.
            Console.WriteLine("--- PROGRAM SONLANDIRILDI !! ---");
        }

        // Seçilen geometrik şekil için hesaplanacak boyutun belirlenmesi sağlanmaktadır.
        public void BoyutBelirle(int secilenSekil)
        {
            // Hesaplama türü seçenekleri kullanıcıya sunulmaktadır.
            Console.WriteLine();
            Console.WriteLine("Hesaplamak istediğiniz boyutu seçiniz :" +
                "\n1-Çevre\n2-Alan\n3-Hacim\n0-Çıkış Yap");

            // Kullanıcının hesaplama türü seçimi alınmaktadır.
            Console.Write("Seçiminiz : ");
            int secilenBoyut = Convert.ToInt32(Console.ReadLine());

            // Seçilen şekil ve hesaplama türü bilgileri ilgili metoda aktarılmaktadır.
            Hesap(secilenSekil, secilenBoyut);
        }

        // Seçilen şekil ve boyut bilgilerine göre matematiksel hesaplamalar gerçekleştirilmektedir.
        public void Hesap(int secilenSekil, int secilenBoyut)
        {
            // Kullanıcının çıkış seçeneğini tercih etmesine kadar hesaplama işlemleri sürdürülmektedir.
            while (secilenBoyut != 0)
            {
                // Seçilen hesaplama türüne göre ilgili işlem bloğuna yönlendirme yapılmaktadır.
                switch (secilenBoyut)
                {
                    case 1:
                        // Çevre hesaplamalarında seçilen geometrik şekle göre işlem yapılmaktadır.
                        if (secilenSekil == 1)
                        {
                            // Dairenin yarıçap bilgisi kullanıcıdan alınmaktadır.
                            Console.Write("Yarıçap giriniz : ");
                            int yarıcap = Convert.ToInt32(Console.ReadLine());

                            // Dairenin çevresi 2πr formülü kullanılarak hesaplanmaktadır.
                            double daireCevre = 2 * Math.PI * yarıcap;

                            // Hesaplanan daire çevresi ekrana yazdırılmaktadır.
                            Console.WriteLine("Dairenin çevresi : " + daireCevre);

                            // Aynı geometrik şekil için yeni hesaplama seçimi yapılmaktadır.
                            BoyutBelirle(secilenSekil);
                        }
                        else if (secilenSekil == 2)
                        {
                            // Üçgenin üç kenar uzunluğu kullanıcıdan virgülle ayrılmış şekilde alınmaktadır.
                            Console.Write("Üçgenin üç kenar uzunluk bilgisini aralarında virgül olacak şekilde giriniz : ");
                            string ucgenKenar = Console.ReadLine();

                            // Girilen kenar uzunlukları virgül karakteri üzerinden diziye aktarılmaktadır.
                            string[] kenarUzunlukları = ucgenKenar.Split(',');

                            // Kenar uzunluklarının toplamını tutacak değişken tanımlanmaktadır.
                            int toplam = 0;

                            // Dizi içerisindeki kenar uzunlukları tek tek işlenmektedir.
                            foreach (var item in kenarUzunlukları)
                            {
                                // Her kenar uzunluğu iki ile çarpılarak toplam değişkenine eklenmektedir.
                                toplam += int.Parse(item) * 2;
                            }

                            // Hesaplanan üçgen çevresi ekrana yazdırılmaktadır.
                            Console.WriteLine("Üçgenin çevresi : " + toplam);

                            // Aynı geometrik şekil için yeni hesaplama seçimi yapılmaktadır.
                            BoyutBelirle(secilenSekil);
                        }
                        else if (secilenSekil == 3)
                        {
                            // Karenin bir kenar uzunluğu kullanıcıdan alınmaktadır.
                            Console.Write("Kenar uzunluğunu giriniz : ");
                            int kenar = Convert.ToInt32(Console.ReadLine());

                            // Karenin çevresi kenar uzunluğunun dört ile çarpılmasıyla hesaplanmaktadır.
                            int toplam = kenar * 4;

                            // Hesaplanan kare çevresi ekrana yazdırılmaktadır.
                            Console.Write("Karenin çevresi : " + toplam);

                            // Aynı geometrik şekil için yeni hesaplama seçimi yapılmaktadır.
                            BoyutBelirle(secilenSekil);
                        }
                        else if (secilenSekil == 4)
                        {
                            // Dikdörtgenin kısa kenar uzunluğu kullanıcıdan alınmaktadır.
                            Console.Write("Kısa kenar uzunluğunu giriniz : ");
                            int kisa = Convert.ToInt32(Console.ReadLine());

                            // Dikdörtgenin uzun kenar uzunluğu kullanıcıdan alınmaktadır.
                            Console.Write("Uzun kenar uzunluğunu giriniz : ");
                            int uzun = Convert.ToInt32(Console.ReadLine());

                            // Dikdörtgenin çevresi kenar uzunluklarının ikişer katlarının toplamıyla hesaplanmaktadır.
                            int toplam = kisa * 2 + uzun * 2;

                            // Hesaplanan dikdörtgen çevresi ekrana yazdırılmaktadır.
                            Console.WriteLine("Dikdörtgenin çevresi : " + toplam);

                            // Aynı geometrik şekil için yeni hesaplama seçimi yapılmaktadır.
                            BoyutBelirle(secilenSekil);
                        }
                        break;

                    case 2:
                        // Alan hesaplamalarında seçilen geometrik şekle göre işlem yapılmaktadır.
                        if(secilenSekil == 1)
                        {
                            // Dairenin yarıçap bilgisi kullanıcıdan alınmaktadır.
                            Console.Write("Yarıçap : ");
                            int yaricap = Convert.ToInt32(Console.ReadLine());

                            // Dairenin alanı πr² formülü kullanılarak hesaplanmaktadır.
                            double alan = Math.PI * yaricap * yaricap;

                            // Hesaplanan daire alanı ekrana yazdırılmaktadır.
                            Console.WriteLine("Dairenin alanı : " + alan);

                            // Aynı geometrik şekil için yeni hesaplama seçimi yapılmaktadır.
                            BoyutBelirle(secilenSekil);
                        } 
                        else if(secilenSekil == 2) 
                        {
                            // Üçgenin yükseklik bilgisi kullanıcıdan alınmaktadır.
                            Console.Write("Yükseklik : ");
                            int yukseklik = Convert.ToInt32(Console.ReadLine());

                            // Üçgenin taban uzunluğu kullanıcıdan alınmaktadır.
                            Console.Write("Taban uzunluğu : ");
                            int tabanUz = Convert.ToInt32(Console.ReadLine());

                            // Üçgenin alanı taban uzunluğu ile yüksekliğin çarpımının ikiye bölünmesiyle hesaplanmaktadır.
                            int alan = (tabanUz * yukseklik) / 2;

                            // Hesaplanan üçgen alanı ekrana yazdırılmaktadır.
                            Console.WriteLine("Üçgenin alanı : " + alan);

                            // Aynı geometrik şekil için yeni hesaplama seçimi yapılmaktadır.
                            BoyutBelirle(secilenSekil);
                        }
                        else if (secilenSekil == 3)
                        {
                            // Karenin bir kenar uzunluğu kullanıcıdan alınmaktadır.
                            Console.Write("Kenar uzunluğu : ");
                            int kenar = Convert.ToInt32(Console.ReadLine());

                            // Karenin alanı kenar uzunluğunun karesi alınarak hesaplanmaktadır.
                            double alan = Math.Pow(kenar, 2);

                            // Hesaplanan kare alanı ekrana yazdırılmaktadır.
                            Console.WriteLine("Karenin alanı : " + alan);

                            // Aynı geometrik şekil için yeni hesaplama seçimi yapılmaktadır.
                            BoyutBelirle(secilenSekil);
                        } 
                        else if (secilenSekil == 4)
                        {
                            // Dikdörtgenin kısa kenar uzunluğu kullanıcıdan alınmaktadır.
                            Console.Write("Kısa kenar: ");
                            int kısa = Convert.ToInt32(Console.ReadLine());

                            // Dikdörtgenin uzun kenar uzunluğu kullanıcıdan alınmaktadır.
                            Console.Write("Uzun kenar : ");
                            int uzun = Convert.ToInt32(Console.ReadLine());

                            // Dikdörtgenin alanı kısa ve uzun kenar uzunluklarının çarpılmasıyla hesaplanmaktadır.
                            int alan = kısa * uzun;

                            // Hesaplanan dikdörtgen alanı ekrana yazdırılmaktadır.
                            Console.WriteLine("Dikdörtgenin alanı : " + alan);

                            // Aynı geometrik şekil için yeni hesaplama seçimi yapılmaktadır.
                            BoyutBelirle(secilenSekil);
                        }
                        break;

                    case 3:
                        // Hacim hesaplamalarında seçilen geometrik şekle göre işlem yapılmaktadır.
                        if(secilenSekil == 1)
                        {
                            // Kürenin yarıçap bilgisi kullanıcıdan alınmaktadır.
                            Console.Write("Yarıçap : ");
                            int yaricap = Convert.ToInt32(Console.ReadLine());

                            // Kürenin hacmi 4/3πr³ formülü kullanılarak hesaplanmaktadır.
                            double hacim = (4 / 3) * Math.PI * Math.Pow(yaricap , 3);

                            // Hesaplanan küre hacmi ekrana yazdırılmaktadır.
                            Console.WriteLine("Kürenin hacmi : " + hacim);

                            // Aynı geometrik şekil için yeni hesaplama seçimi yapılmaktadır.
                            BoyutBelirle(secilenSekil);
                        }
                        else if (secilenSekil == 2)
                        {
                            // Üçgen prizmanın taban kenar uzunluğu kullanıcıdan alınmaktadır.
                            Console.Write("Kenar uzunluğu : ");
                            int kenar = Convert.ToInt32(Console.ReadLine());

                            // Üçgen prizmanın yükseklik bilgisi kullanıcıdan alınmaktadır.
                            Console.Write("Yükseklik : ");
                            int yukseklik = Convert.ToInt32(Console.ReadLine());

                            // Üçgen prizmanın hacmi eşkenar üçgen taban alanı ve yükseklik kullanılarak hesaplanmaktadır.
                            double hacim = (((kenar * kenar) * Math.Sqrt(3)) / 4) * yukseklik;

                            // Hesaplanan üçgen prizma hacmi ekrana yazdırılmaktadır.
                            Console.WriteLine("Üçgenin hacmi : " + hacim);

                            // Aynı geometrik şekil için yeni hesaplama seçimi yapılmaktadır.
                            BoyutBelirle(secilenSekil);
                        } 
                        else if (secilenSekil == 3)
                        {
                            // Küpün bir kenar uzunluğu kullanıcıdan alınmaktadır.
                            Console.Write("Kenar uzunluğu : ");
                            int kenar = Convert.ToInt32(Console.ReadLine());

                            // Küpün hacmi kenar uzunluğunun küpü alınarak hesaplanmaktadır.
                            double hacim = Math.Pow(kenar, 3);

                            // Hesaplanan küp hacmi ekrana yazdırılmaktadır.
                            Console.WriteLine("Küpün hacmi : " + hacim);

                            // Aynı geometrik şekil için yeni hesaplama seçimi yapılmaktadır.
                            BoyutBelirle(secilenSekil);
                        } 
                        else if (secilenSekil == 4)
                        {
                            // Dikdörtgenler prizmasının kısa kenar uzunluğu kullanıcıdan alınmaktadır.
                            Console.Write("Kısa kenar : ");
                            int kısa = Convert.ToInt32(Console.ReadLine());

                            // Dikdörtgenler prizmasının uzun kenar uzunluğu kullanıcıdan alınmaktadır.
                            Console.Write("Uzun kenar : ");
                            int uzun = Convert.ToInt32(Console.ReadLine());

                            // Dikdörtgenler prizmasının hacmi kenar uzunlukları kullanılarak hesaplanmaktadır.
                            double hacim = kısa * uzun * kısa;

                            // Hesaplanan dikdörtgenler prizması hacmi ekrana yazdırılmaktadır.
                            Console.WriteLine("Dikdörtgenin hacmi : " + hacim);

                            // Aynı geometrik şekil için yeni hesaplama seçimi yapılmaktadır.
                            BoyutBelirle(secilenSekil);
                        }
                        break;
                }
            }

            // Hesaplama menüsünden çıkış yapıldığı bilgisi kullanıcıya bildirilmektedir.
            Console.WriteLine("\nÇıkış Yapıldı...");

            // İşlem menüsüne yeniden yönlendirme yapılmaktadır.
            IslemMenusu();
        }
    }
}