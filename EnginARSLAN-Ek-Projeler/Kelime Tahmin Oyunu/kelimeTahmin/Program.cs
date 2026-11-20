
Console.WriteLine("Kelime Tahmin Oyununa Hoşgeldiniz! ");
Console.WriteLine("5 hakkınız var. Her yanlış tahminde bir hak kaybedeceksiniz.\n");

// kelimeler dizisi oluşturuyoruz. Kullanıcıdan kelime tahmin etmesini isteyeceğiz.
String[] kelimeler = { "Meslek", "Yazılım", "Yükseokulu", "Adli Bilişim", "Siber Güvenlik" };

// rastgele bir kelime seçmek için Random kütüphanesini kullanıyoruz.
Random rastgele = new Random();
string rastgeleKelime = kelimeler[rastgele.Next(kelimeler.Length)]; // rastgele kelimeyi seçiyoruz.

Console.WriteLine("Sistem Tarafından Seçilen Kelime: " + rastgeleKelime + "\nYALNIZCA TEST AMAÇLI"); // rastgele kelimeyi ekrana yazdırıyoruz. (Bu satır yalnızca test amaçlı)

// kelimenin uzunluğunu öğreniyoruz.
int kelimeUzunlugu = rastgeleKelime.Length;

Console.WriteLine("Kelimenin uzunluğu: " + kelimeUzunlugu);

// kelimenin harflerini gizlemek için bir dizi oluşturuyoruz.
char[] gizliKelime = new char[rastgeleKelime.Length]; // Orijinal uzunluk
for (int i = 0; i < rastgeleKelime.Length; i++) // Orijinal uzunluğa göre dön
{
    if (rastgeleKelime[i] == ' ')
        gizliKelime[i] = ' ';
    else
        gizliKelime[i] = '*';
}

Console.WriteLine("Kelime: " + new string(gizliKelime) + "\n"); // gizli kelimeyi ekrana yazdırıyoruz.
// kullanıcıdan tahmin alıyoruz.
int kalanHak = 5; // kullanıcının kelimeyi doğru tahmin etmesi için tanımlanan tahmin hakkı

while (kalanHak > 0)
{
    Console.Write("Bir harf tahmin edin: ");
    char tahmin = Console.ReadLine()[0]; // kullanıcıdan bir harf tahmin etmesini istiyoruz.

    // Geçersiz tahmin kontrolü
    if (tahmin == ' ')
    {
        Console.Clear(); // ekranı temizliyoruz.
        Console.WriteLine("Kelime: " + new string(gizliKelime) + "\n");  // güncellenmiş gizli kelimeyi ekrana yazdırıyoruz.
        Console.WriteLine("Boşluk karakteri tahmin edilemez! Lütfen geçerli bir harf girin.\n");
    }
    else
    {
        bool dogruTahmin = false; // doğru tahmin olup olmadığını kontrol etmek için bir değişken tanımlıyoruz.
        for (int i = 0; i < rastgeleKelime.Length; i++)
        {
            if (char.ToUpper(rastgeleKelime[i]) == char.ToUpper(tahmin)) // eğer tahmin edilen harf kelimenin içinde varsa
            {
                gizliKelime[i] = rastgeleKelime[i]; // gizli kelimenin ilgili harfini açıyoruz.
                dogruTahmin = true; // doğru tahmin yapıldığını belirtiyoruz.
            }
        }
        if (!dogruTahmin) // eğer doğru tahmin yapılmadıysa
        {
            Console.Clear(); // ekranı temizliyoruz.
            kalanHak--; // kalan hak sayısını azaltıyoruz.
            Console.WriteLine("Yanlış tahmin! Kalan hak: " + kalanHak);
        }
        else
        {
            Console.Clear(); // ekranı temizliyoruz.
            Console.WriteLine("Doğru tahmin! Kalan hak hâlâ: " + kalanHak);
        }

        Console.WriteLine("Kelime: " + new string(gizliKelime) + "\n"); // güncellenmiş gizli kelimeyi ekrana yazdırıyoruz.

        if (new string(gizliKelime) == rastgeleKelime) // eğer gizli kelime, rastgele kelimeye eşitse
        {
            Console.Clear(); // ekranı temizliyoruz.
            Console.WriteLine("Tebrikler! Kelimeyi doğru tahmin ettiniz.\n");
            Console.WriteLine("Kelime: " + "\"" + rastgeleKelime + "\"" + " idi\n"); // doğru tahmin edilen kelimeyi ekrana yazdırıyoruz.
            break; // döngüden çıkıyoruz.
        }
    }
    if (kalanHak == 0) // eğer kalan hak sıfırsa
    {
        Console.WriteLine("Üzgünüm, kelimeyi doğru tahmin edemediniz. Doğru kelime: " + rastgeleKelime);
    }
}
// oyunun bitiş mesajını ekrana yazdırıyoruz.
Console.WriteLine("Oyun bitti. Teşekkürler!");

Console.ReadLine(); // .exe dosyasını kapatmaz
