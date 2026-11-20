namespace MutlakKareAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan işleme alınacak sayısal değerler alınmaktadır.
            Console.Write("Sayı giriniz: ");
            string sayilar = Console.ReadLine();

            // Girilen sayılar boşluk karakteri üzerinden ayrıştırılarak diziye aktarılmaktadır.
            string[] sayiListesi = sayilar.Split(' ');

            // 67 değerinden küçük sayıların farklarını toplamak amacıyla değişken tanımlanmaktadır.
            int toplam = 0;

            // 67 değerinden büyük veya eşit sayıların karelerinin toplamını tutmak amacıyla değişken tanımlanmaktadır.
            double mutlakToplam = 0;

            // Sayı listesindeki değerler tek tek işlenmektedir.
            foreach (var sayi in sayiListesi)
            {
                // Mevcut metinsel değer integer türüne dönüştürülmektedir.
                int x = int.Parse(sayi);

                // Sayının 67 değerinden küçük olup olmadığı kontrol edilmektedir.
                if(x < 67)
                {
                    // 67 ile mevcut sayı arasındaki fark hesaplanmaktadır.
                    int y = 67 - x;

                    // Hesaplanan fark toplam değişkenine eklenmektedir.
                    toplam += y;
                }
                else
                {
                    // 67 ile mevcut sayı arasındaki farkın karesi hesaplanmaktadır.
                    double a = Math.Pow(x - 67, 2);   

                    // Hesaplanan kare değeri mutlakToplam değişkenine eklenmektedir.
                    mutlakToplam += a;
                }
            }

            // Her iki hesaplama sonucunu içeren değerler ekrana yazdırılmaktadır.
            Console.Write(toplam + " " + mutlakToplam);
        }
    }
}