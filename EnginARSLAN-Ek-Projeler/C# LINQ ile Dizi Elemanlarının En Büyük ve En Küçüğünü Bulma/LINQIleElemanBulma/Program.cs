
// LINQ İLE DİZİNİN EN BÜYÜK VE EN KÜÇÜK ELEMANINI BULMA

// 1. Adım: Gerekli kütüphaneleri ekleyin
using System.Linq; // LINQ kütüphanesi .NET 6+ üstü sürümlerde yazılmasına gerek yoktur! 

// 2. Adım: 40 elemanlı bir int dizisi oluşturun
int[] dizi = {
    45, 78, 23, 56, 89, 12, 34, 67, 90, 123,
    456, 789, 321, 654, 987, 234, 567, 890, 345, 678,
    901, 432, 765, 109, 876, 543, 210, 987, 654, 321,
    135, 246, 357, 468, 579, 680, 791, 802, 913, 102
};

// 3. Adım: Dizinin en büyük ve en küçük elemanı için değişken tanımlama ve değerlerini atama 
int enBuyuk = dizi.Max(); // Dizinin en büyük elemanını bul 
int enKucuk = dizi.Min(); // Dizinin en küçük elemanını bul

// 4. Adım: Sonuçları ekrana yazdırma
Console.WriteLine("Dizinin en büyük elemanı: " + enBuyuk);
Console.WriteLine("Dizinin en küçük elemanı: " + enKucuk);
