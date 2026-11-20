using System.Text;

namespace SessizHarf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Türkçe alfabedeki sessiz harfler bir metin değişkeninde tanımlanmaktadır.
            string sessizHarf = "bcdfgğhjklmnprsştvyz";

            // Kelime içerisinde yan yana iki sessiz harf bulunup bulunmadığını kontrol etmek amacıyla değişken tanımlanmaktadır.
            bool yanYana = false;

            // Mevcut kelimenin sayısal değer içerip içermediğini belirlemek amacıyla değişken tanımlanmaktadır.
            bool sayiMi = false;

            // Kullanıcıdan sessiz harf kontrolü yapılacak cümle alınmaktadır.
            Console.Write("Bir cümle giriniz : ");
            string input = Console.ReadLine();

            // Girilen cümle boşluk karakteri üzerinden kelimelere ayrıştırılmaktadır.
            string[] kelimeler = input.Split(' ');

            // Cümle içerisindeki kelimeler tek tek işlenmektedir.
            foreach(string kelime in kelimeler)
            {
                try
                {
                    // Mevcut kelimenin integer türüne dönüştürülmesi denenerek sayısal olup olmadığı kontrol edilmektedir.
                    int.Parse(kelime);

                    // Sayısal değer tespit edildiğinde ilgili kontrol değişkeni true olarak güncellenmektedir.
                    sayiMi = true;

                    // Sayısal değerler için karakter kontrolü yapılmadan sonraki kelimeye geçilmektedir.
                    continue;
                }
                catch (Exception)
                {
                    // Sayısal dönüşüm gerçekleştirilemediğinde mevcut değerin kelime olduğu kabul edilmektedir.
                    sayiMi = false;   
                }

                // Sayısal olmayan kelimeler üzerinde sessiz harf kontrolü gerçekleştirilmektedir.
                if (sayiMi == false)
                {
                    // Kelimenin karakterleri indeks değerleri üzerinden tek tek kontrol edilmektedir.
                    for (int i = 0; i < kelime.Length; i++)
                    {
                        // Son karaktere ulaşıldığında sonraki karakter bulunmadığından kontrol sonlandırılmaktadır.
                        if (i == (kelime.Length - 1))
                        {
                            // Yan yana sessiz harf bulunmadığı varsayımıyla kontrol değişkeni false olarak güncellenmektedir.
                            yanYana = false;
                            break;
                        }

                        // Mevcut karakterin ve kendisinden sonraki karakterin sessiz harf olup olmadığı kontrol edilmektedir.
                        if (sessizHarf.Contains(kelime[i]) && sessizHarf.Contains(kelime[i + 1]))
                        {
                            // Yan yana iki sessiz harf tespit edildiğinde kontrol değişkeni true olarak güncellenmektedir.
                            yanYana = true;
                            break;
                        }
                    }

                    // Kelimeye ait sessiz harf kontrolünün sonucu ekrana yazdırılmaktadır.
                    Console.Write(yanYana + " ");
                }
            }
        }
    }
}