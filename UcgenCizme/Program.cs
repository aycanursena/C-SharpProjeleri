namespace UcgenCizme
{
    internal class Program
    {
        // Programın başlangıç noktası olan Main metodu içerisinde üçgen çizim işlemi gerçekleştirilmektedir.
        static void Main(string[] args)
        {
            // Çizilecek üçgenin satır sayısını belirlemek üzere kullanıcıdan tam sayı değeri alınmaktadır.
            Console.Write("Bir sayı giriniz : ");
            int inp = Convert.ToInt32(Console.ReadLine());

            // Girilen sayı kadar satır oluşturulmasını sağlayan dış döngü çalıştırılmaktadır.
            for (int i = 0; i < inp; i++)
            {
                // Her satırda, mevcut satır numarasına bağlı olarak yıldız karakteri yazdırılmaktadır.
                for (int a = 0; a <= i; a++)
                {
                    Console.Write("*");
                }

                // Yıldız karakterlerinin yazdırılması tamamlandıktan sonra bir alt satıra geçilmektedir.
                Console.WriteLine();
            }
        }
    }
}