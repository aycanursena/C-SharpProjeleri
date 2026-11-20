namespace Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Girilen değerlerin sayı olup olmadığının kontrolünde kullanılacak değişken tanımlanmaktadır.
            bool sayiMi = false;

            // Sayı listesindeki elemanlara erişim sağlamak amacıyla indeks değişkeni tanımlanmaktadır.
            int x = 0;

            // Kullanıcıdan virgülle ayrılmış kelime ve sayı bilgileri alınmaktadır.
            Console.Write("Bir kelime ve bir sayı giriniz (aralarında virgül ile) : ");
            string input = Console.ReadLine();

            // Girilen metin virgül karakteri üzerinden parçalanarak diziye aktarılmaktadır.
            string[] girilenDeger = input.Split(',');

            // Sayısal değerlerin saklanması amacıyla integer türünde liste oluşturulmaktadır.
            List<int> sayilar = new List<int>();

            // Sayısal olmayan değerlerin saklanması amacıyla string türünde liste oluşturulmaktadır.
            List<string> kelimeler = new List<string>();

            // Parçalanan değerler tek tek kontrol edilerek ilgili listelere aktarılmaktadır.
            foreach (var item in girilenDeger)
            {
                try
                {
                    // Mevcut değerin integer türüne dönüştürülmesi denenmektedir.
                    int a = int.Parse(item);

                    // Dönüştürülen sayısal değer sayılar listesine eklenmektedir.
                    sayilar.Add(a);

                    // Sayısal değer bulunduğunu belirtmek amacıyla değişkene true atanmıştır.
                    sayiMi = true;
                }
                catch (Exception)
                {
                    // Sayısal dönüşüm gerçekleştirilemeyen değerler kelimeler listesine eklenmektedir.
                    kelimeler.Add(item);
                }
            }

            // Kelimeler listesinde bulunan metinler tek tek işlenmektedir.
            foreach (string kelime in kelimeler)
            {
                // Mevcut kelimenin karakterleri üzerinde döngü aracılığıyla ilerlenmektedir.
                for (int i = 0; i < kelime.Length; i++)
                {
                    // Karakterin indeks değeri, sayılar listesindeki ilgili değerle karşılaştırılmaktadır.
                    if (i == sayilar[x])
                    {
                        // Belirlenen indeks konumundaki karakteri kaldırma işlemi gerçekleştirilmeye çalışılmaktadır.
                        kelime.Remove(i);

                        // Koşul sağlandığında mevcut döngü adımının devamı atlanmaktadır.
                        continue;
                    }

                    // Koşula takılmayan karakterler ekrana yazdırılmaktadır.
                    Console.Write(kelime[i]);
                }

                // Bir sonraki kelime için sayı listesindeki indeks bir artırılmaktadır.
                x++;

                // İşlenen kelimenin ardından alt satıra geçilmektedir.
                Console.WriteLine();
            }
        }
    }
}