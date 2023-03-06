using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingUygulamasi
{
    internal class Oylama
    {
        public void Giris()
        {

            int film = 0, tech = 0, spor = 0, kitap = 0, dizi = 0;

            List<string> kayıtlıKullanıcılar = new List<string>
            {
                "ayca123", "nur456", "ali003"
            };

            Console.Write("Lütfen oy vermek istediğiniz kategoriyi seçiniz :\n" +
                "(1) Film\n" +
                "(2) Tech Stack\n" +
                "(3) Spor\n" +
                "(4) Kitap\n" +
                "(5) Dizi\n" +
                "(0) Çıkış Yap" +
                "\n\nSeçiminiz : ");

            int secim = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen kullanıcı adınızı giriniz : ");
            string kullanıcıAdi = Console.ReadLine();

            if (kayıtlıKullanıcılar.Contains(kullanıcıAdi))
            {

            }
            else
            {
                Console.WriteLine("Devam etmek için sisteme kayıt olmalısınız !!");
                Console.Write("Kullanıcı adı belirleyiniz : ");
                string yeniKullanici = Console.ReadLine();

                if (kayıtlıKullanıcılar.Contains(yeniKullanici))
                {
                    Console.Write("Bu kullanıcı adı daha önce alınmış.\n" +
                           "Lütfen yeni kullanıcı adı belirleyiniz : ");
                    yeniKullanici = Console.ReadLine();
                }
                else
                {
                    kayıtlıKullanıcılar.Add(yeniKullanici);
                }
            }


            while (secim != 0)
            {
                switch (secim)
                {
                    case 1:
                        film++;

                        break;
                    case 2:
                        tech++;

                        break;
                    case 3:
                        spor++;

                        break;
                    case 4:
                        kitap++;

                        break;
                    case 5:
                        dizi++;

                        break;
                }
            }

            int toplamOy = film + tech + spor + kitap + dizi;

            Console.WriteLine("Film kategorisi oyları : " + film + "Yüzde : " + (film * 100) / toplamOy);
            Console.WriteLine("Tech Stack kategorisi oyları : " + tech + "Yüzde : " + (tech * 100) / toplamOy);
            Console.WriteLine("Spor kategorisi oyları : " + spor + "Yüzde : " + (spor * 100) / toplamOy);
            Console.WriteLine("Kitap kategorisi oyları : " + kitap + "Yüzde : " + (kitap * 100) / toplamOy);
            Console.WriteLine("Dizi kategorisi oyları : " + dizi + "Yüzde : " + (dizi * 100) / toplamOy);
            Console.WriteLine("--- PROGRAM SONLANDIRILDI !! ---");

        }
    }
}
