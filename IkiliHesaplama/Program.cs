namespace IkiliHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan ikili hesaplamada kullanılacak sayısal değerler alınmaktadır.
            Console.Write("Hesaplanacak sayıları giriniz : ");
            string sayılar = Console.ReadLine();

            // Girilen sayılar boşluk karakteri üzerinden ayrıştırılarak diziye aktarılmaktadır.
            string[] sayilar = sayılar.Split(' ');

            // Sayılar ikişerli gruplar halinde işlenmektedir.
            for(int i = 0; i < sayilar.Length; i+=2)
            {
                // İkili gruptaki sayıların birbirinden farklı olup olmadığı kontrol edilmektedir.
                if (sayilar[i] != sayilar[i + 1])
                {
                    // Birbirinden farklı olan sayıların toplamı hesaplanmaktadır.
                    int toplam = int.Parse(sayilar[i]) + int.Parse(sayilar[i + 1]);

                    // Hesaplanan toplam ekrana yazdırılmaktadır.
                    Console.Write(toplam + " ");
                }else
                {
                    // Birbirine eşit olan sayısal değer dönüştürülerek değişkene aktarılmaktadır.
                    int b = int.Parse(sayilar[i]);

                    // Sayının dördüncü kuvveti hesaplanmaktadır.
                    double sonuc = Math.Pow(b * b, 2);

                    // Hesaplanan sonuç ekrana yazdırılmaktadır.
                    Console.Write(sonuc + " ");
                }
            }
        }
    }
}