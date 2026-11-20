
// BİR DİZİNİN EN BÜYÜK VE EN KÜÇÜK ELEMANLARINI BULMA

// 1. Adım: 30 elemanlı bir dizi tanımlama ve elemanları atama 
int[] E_ArslanDizi = {
    105, 212, 387, 420, 303, 518, 611, 725, 909, 801,
    930, 822, 404, 617, 306, 713, 829, 915, 202, 110,
    808, 623, 719, 916, 821, 714, 926, 827, 928, 824
};

// 2. Adım: En büyük ve en küçük elemanları bulmak için değişkenler tanımlama 
int enBuyuk = E_ArslanDizi[0]; // Dizinin ilk elemanını en BÜYÜK olarak varsayıyoruz
int enKucuk = E_ArslanDizi[0]; // Dizinin ilk elemanını en KÜÇÜK olarak varsayıyoruz

// 3. Adım: Dizi elemanlarını döngü ile kontrol edip en küçük ve en büyük elemanları bulma
for (int i = 0; i < E_ArslanDizi.Length; i++) {

    // DİZİNİN EN BÜYÜK ELEMANINI BULMA
    if (E_ArslanDizi[i] > enBuyuk) {
        // Eğer en büyük eleman dizinin i. elemanından büyükse, en büyük elemanı güncelle
        enBuyuk = E_ArslanDizi[i]; 
    }

    // DİZİNİN EN KÜÇÜK ELEMANINI BULMA
    if (E_ArslanDizi[i] < enKucuk) {
        // Eğer en küçük eleman dizinin i. elemanından küçükse, en küçük elemanı güncelle
        enKucuk = E_ArslanDizi[i]; 
    }

}

// 4. Adım: En büyük ve en küçük elemanları ekrana yazdırma
Console.WriteLine("Dizinin en büyük elemanı: " + enBuyuk);
Console.WriteLine("Dizinin en küçük elemanı: " + enKucuk);