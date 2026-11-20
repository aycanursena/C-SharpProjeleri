namespace TerstenYazdir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan karakterleri üzerinde işlem yapılacak ifade alınmaktadır.
            Console.Write("Bir ifade giriniz : ");
            string input = Console.ReadLine();

            // Girilen ifade boşluk karakteri üzerinden kelimelere ayrıştırılmaktadır.
            string[] kelime = input.Split(' ');

            // İfade içerisindeki kelimeler tek tek işlenmektedir.
            foreach (string s in kelime)
            {
                // Her kelimenin ilk karakteri dışındaki karakterleri sırasıyla ekrana yazdırılmaktadır.
                for (int i = 1; i < s.Length; i++)
                {
                    Console.Write(s[i]);
                }

                // Kelimenin ilk karakteri sona alınarak kelimenin karakter sıralaması değiştirilmiş şekilde yazdırılmaktadır.
                Console.Write(s[0] + " ");
            }
        }
    }
}