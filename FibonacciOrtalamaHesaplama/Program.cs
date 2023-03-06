namespace FibonacciOrtalamaHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 1, b = 1, c, toplam = 2;
            Console.Write("Bir sayı giriniz : ");
            float input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--- SERİ ---");
            Console.Write(a + " " +  b + " ");
            for (int i = 0; i < input - 2; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(c + " ");
                toplam += c;
            }
            float ort = toplam / input;
            Console.WriteLine();
            Console.WriteLine("Ortalama : " + ort);
        }
    }
}