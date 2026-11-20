// Uygulama Adı : Sayi Tahmin Oyunu
// Kod Yazarı : Engin Arslan

int kalanHak = 5; // Kullanıcının tahmin hakkı (kalan hak sayısı)
int toplamGirilenSayi = 0; // Kullanıcının girdiği toplam sayı (kullanıcıdan alınan sayılar için kullanılacak)

Random r = new Random(); // Rastgele sayı üretmek için Random sınıfından bir nesne oluşturuyoruz
int sistemSayisi = r.Next(1, 51); // 1 ile 50 arasında rastgele bir sayı üretiyoruz

Console.WriteLine("Sistem Tarafından Tutulmuş Olan Sayı: " + sistemSayisi + " TEST AMAÇLI GÖSTERİLİYOR!! " + "\n"); // Rastgele üretilen sayıyı ekrana yazdırıyoruz (test amaçlı)

// Kullanıcının tahmin ettiği sayıyı tutacak değişken (başta 0 değeri veriliyor ki döngüde kullanabilmek için)
int tahminSayisi = 0; 

Console.WriteLine("Sayı Tahmin Oyununa Hoş Geldiniz!" + "\n" + "Sayıyı tahmin etmek için toplam 5 hakkınız bulunmaktadır" + "\n"); 

// Kullanıcıdan alınan sayı sistemin seçmiş olduğu sayı ile eşit oluncaya kadar tahmin alma döngüsü 
while (sistemSayisi != tahminSayisi) { 
    Console.WriteLine("Lütfen 1 ile 50 arasında bir sayı tahmin ediniz: "); // Kullanıcıdan tahmin alıyoruz
    tahminSayisi = Convert.ToInt32(Console.ReadLine()); // Kullanıcının girdiği değeri int'e çevirip tahminSayisi değişkenine atıyoruz

    kalanHak--; // Kullanıcının tahmin hakkını bir azaltıyoruz
    toplamGirilenSayi += 1; // Kullanıcının girdiği toplam sayı değişkenine 1 ekliyoruz

    if (tahminSayisi == sistemSayisi)
    {
        Console.Clear(); // Konsole ekranını temizliyoruz

        // Kullanıcı ilk denemesinde doğru tahmin ettiyse bu mesajı veriyoruz
        if (toplamGirilenSayi == 1) {
            Console.WriteLine("Tebrikler! İLK Denemenizde Sayıyı Doğru Tahmin Ettiniz. "); // Kullanıcı doğru tahmin ettiğinde bu mesajı veriyoruz 
            Console.WriteLine("Sistem tarafından tutulmuş olan sayı " + sistemSayisi + " idi ");
        }
        else { 
            Console.WriteLine("Tebrikler! " + toplamGirilenSayi + ". Denemenizde Sayıyı Doğru Tahmin Ettiniz. "); // Kullanıcı doğru tahmin ettiğinde bu mesajı veriyoruz 
            Console.WriteLine("Sistem tarafından tutulmuş olan sayı " + sistemSayisi + " idi ");
        }
            
    }
    else if (tahminSayisi > sistemSayisi)
    {
        Console.Clear(); // Konsole ekranını temizliyoruz
        Console.WriteLine("Tahmininiz çok yüksek! "); // Kullanıcı tahmin ettiği sayı sistemin sayısından büyükse bu mesajı veriyoruz
        Console.WriteLine("Kalan tahmin hakkınız: " + kalanHak); // Kullanıcının kalan tahmin hakkını gösteriyoruz 
    }
    else if (tahminSayisi < sistemSayisi)
    {
        Console.Clear(); // Konsole ekranını temizliyoruz
        Console.WriteLine("Tahmininiz çok düşük! "); // Kullanıcı tahmin ettiği sayı sistemin sayısından küçükse bu mesajı veriyoruz
        Console.WriteLine("Kalan tahmin hakkınız: " + kalanHak); // Kullanıcının kalan tahmin hakkını gösteriyoruz 
    }
    else {
        Console.Clear(); // Konsole ekranını temizliyoruz

        // Kullanıcı geçerli bir sayı girmediğinde veya sistemsel hatada bu mesajı veriyoruz
        Console.WriteLine("Lütfen geçerli bir sayı giriniz! " + "\n" + "Hata ile karşılaşıyorsanız lütfen birisi@gmail.com adresinden bize bildiriniz. "); 
    }

    // Kullanıcının tahmin hakkı kalmadığında bu mesajı veriyoruz
    if (kalanHak == 0) // Kullanıcının tahmin hakkı kalmadığında bu mesajı veriyoruz
    {
        Console.Clear(); // Konsole ekranını temizliyoruz
        Console.WriteLine("Tahmin hakkınız kalmadı! " + "\n" + "Sistem tarafından tutulmuş olan sayı " + sistemSayisi + " idi "); // Kullanıcı tahmin hakkı kalmadığında bu mesajı veriyoruz
        break; // Döngüden çıkıyoruz
    }
}

// .exe dosyası çalışırken uygulamanın kapanmaması için (oyun bitince herhangi bir tuşa basınca kapansın)
Console.ReadKey();  
