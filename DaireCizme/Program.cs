namespace DaireCizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dairenin yarıçap bilgisini tutacak değişken tanımlanmaktadır.
            double yaricap;

            // Daire çiziminde kullanılacak kalınlık değeri belirlenmektedir.
            double kalinlik = 0.4;

            // Kullanıcıdan dairenin yarıçap bilgisi alınmaktadır.
            Console.Write("Yarıçapını giriniz: ");

            // Girilen değerin sayısal olup olmadığı ve pozitif değer içerip içermediği kontrol edilmektedir.
            if (!double.TryParse(Console.ReadLine(), out yaricap) || yaricap <= 0)
            {
                // Geçersiz yarıçap bilgisi girildiğinde kullanıcı bilgilendirilmektedir.
                Console.WriteLine("Yarıçapta negatif değer girilemez !!");

                // Geçersiz giriş durumunda programın çalışması sonlandırılmaktadır.
                return;
            }

            // Yarıçapın pozitif değer olması kontrol edilmektedir.
            while (yaricap <= 0) ;

            // Dairenin iç ve dış sınırlarını belirlemek amacıyla yarıçap değerleri hesaplanmaktadır.
            Console.WriteLine();
            double rin = yaricap - kalinlik, rOut = yaricap + kalinlik;

            // Dairenin dikey eksenindeki koordinatlar üzerinde ilerlenmektedir.
            for (double y = yaricap; y >= -yaricap; --y)
            {
                // Dairenin yatay eksenindeki koordinatlar belirlenen artış miktarıyla ilerletilmektedir.
                for (double x = -yaricap; x < rOut; x += 0.5)
                {
                    // Mevcut koordinatın merkeze olan uzaklığının karesi hesaplanmaktadır.
                    double value = x * x + y * y;

                    // Koordinatın dairenin iç ve dış sınırları arasında bulunup bulunmadığı kontrol edilmektedir.
                    if (value >= rin * rin && value <= rOut * rOut)
                    {
                        // Belirlenen sınırlar içerisinde kalan koordinatlara yıldız karakteri yazdırılmaktadır.
                        Console.Write("*");
                    }
                    else
                    {
                        // Daire sınırları dışında kalan koordinatlar boşluk karakteriyle gösterilmektedir.
                        Console.Write(" ");
                    }
                }

                // Her yatay koordinat satırının tamamlanmasının ardından alt satıra geçilmektedir.
                Console.WriteLine();
            }

            // Kullanıcıdan bir tuşa basması beklenerek konsol ekranının açık kalması sağlanmaktadır.
            Console.ReadKey();
        }
    }
}