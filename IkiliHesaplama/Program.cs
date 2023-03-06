namespace IkiliHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hesaplanacak sayıları giriniz : ");
            string sayılar = Console.ReadLine();
            string[] sayilar = sayılar.Split(' ');
            
            for(int i = 0; i < sayilar.Length; i+=2)
            {
                if (sayilar[i] != sayilar[i + 1])
                {
                    int toplam = int.Parse(sayilar[i]) + int.Parse(sayilar[i + 1]);
                    Console.Write(toplam + " ");
                }else
                {
                    int b = int.Parse(sayilar[i]);
                    double sonuc = Math.Pow(b * b, 2);
                    Console.Write(sonuc + " ");
                }
            }
        }
    }
}