namespace FibonacciOrtalamaHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fibonacci serisinin ilk iki elemanı ve başlangıç toplamı tanımlanmaktadır.
            float a = 1, b = 1, c, toplam = 2;

            // Kullanıcıdan Fibonacci serisinin eleman sayısı alınmaktadır.
            Console.Write("Bir sayı giriniz : ");
            float input = Convert.ToInt32(Console.ReadLine());

            // Fibonacci serisinin başlangıç başlığı ekrana yazdırılmaktadır.
            Console.WriteLine("--- SERİ ---");

            // Serinin ilk iki elemanı ekrana yazdırılmaktadır.
            Console.Write(a + " " +  b + " ");

            // İlk iki elemandan sonraki Fibonacci sayıları döngü aracılığıyla hesaplanmaktadır.
            for (int i = 0; i < input - 2; i++)
            {
                // Önceki iki Fibonacci elemanının toplamı alınarak yeni eleman hesaplanmaktadır.
                c = a + b;

                // Bir sonraki hesaplama için önceki elemanların değerleri güncellenmektedir.
                a = b;
                b = c;

                // Hesaplanan yeni Fibonacci elemanı ekrana yazdırılmaktadır.
                Console.Write(c + " ");

                // Hesaplanan eleman toplam değişkenine eklenmektedir.
                toplam += c;
            }

            // Fibonacci serisindeki elemanların aritmetik ortalaması hesaplanmaktadır.
            float ort = toplam / input;

            // Seri gösteriminin ardından alt satıra geçilmektedir.
            Console.WriteLine();

            // Hesaplanan aritmetik ortalama ekrana yazdırılmaktadır.
            Console.WriteLine("Ortalama : " + ort);
        }
    }
}