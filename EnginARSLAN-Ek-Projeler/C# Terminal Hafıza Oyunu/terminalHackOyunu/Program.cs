using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Sonsuz döngü: kullanıcı oyunu tekrar oynamak isterse devam eder
        while (true)
        {
            // Rastgele üretim için Random nesnesi
            Random rnd = new Random();

            // Karakter havuzu
            string[] pool = { "A", "B", "C", "X", "Z", "1", "2", "3", "9", "8" };

            // Yeni bir şifre oluşturuluyor
            string secretCode = GenerateCode(4, pool, rnd);

            // Oyuna giriş
            Console.Clear();     // Ekranı temizle
            Console.WriteLine("Hafıza Terminal Oyunu");
            Console.WriteLine("Birazdan random bir şifre gösterilecektir! Oyunu başarıyla tamamlamak için bu şifreyi aklınızda tutunuz!!\n");
            Console.WriteLine("Devam etmek için bir tuşa bas...");
            Console.ReadKey();

            // Şifre gösterimi
            Console.Clear(); 
            Console.WriteLine($"Şifre: {secretCode}");
            Console.WriteLine("Şifre 2 saniye içinde kaybolacak, aklında tut!");
            Thread.Sleep(2000); // Şifre 2 saniye gösteriliyor

            // Ekranı temizle
            Console.Clear();

            // Kullanıcıya 3 tahmin hakkı tanınır
            int attemptsLeft = 3;
            bool success = false;

            while (attemptsLeft > 0)
            {
                Console.Write($"\nŞifreyi gir ({attemptsLeft} hakkın kaldı): ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.Clear();
                    Console.WriteLine("Şifre tahmini boş olamaz! lütfen geçerli bir tahmin giriniz. \n");
                }
                else if (input == " ")
                {
                    Console.Clear();
                    Console.WriteLine("Şifre boşluk içermez! \n");
                }
                else if (input.ToUpper() == secretCode)
                {
                    Console.Clear(); // Ekranı temizle
                    Console.WriteLine("Tebrikler, DOĞRU ŞİFRE! Erişim onaylandı.");
                    success = true;
                    break;
                }
                else
                {
                    Console.Clear(); // Ekranı temizle
                    Console.WriteLine("Hatalı şifre.");
                    attemptsLeft--;
                }
            }

            // Eğer şifre doğru tahmin edilemezse
            if (!success)
            {
                Console.Clear(); // Ekranı temizle
                Console.WriteLine($"\nTüm haklar tükendi. Doğru şifre: {secretCode}");
            }

            // Oyun sonu - tekrar oynamak ister misin?
            Console.Write("\nTekrar oynamak ister misin? (E/H): ");
            string answer = Console.ReadLine().ToUpper();

            if (answer != "E")
            {
                Console.WriteLine("Çıkılıyor...");
                break; // Oyun döngüsünden çık
            }
        }

        // Console.ReadLine(); // .exe dosyasında programın sonlanması bir tuşa bastıkktan sonra gerçekleşmesi için 
    }

    // Yardımcı metot: Rastgele şifre üretir
    static string GenerateCode(int length, string[] pool, Random rnd)
    {
        string result = "";
        for (int i = 0; i < length; i++)
            result += pool[rnd.Next(pool.Length)];
        return result;
    }
}
