
// Dizinin kaç elemanlı olacağını kullanıcıdan alıp, diziBoyutu deişkenine atama 
Console.Write("Diziniz Kaç Elemanlı Olacaktır? ");
int diziBoyutu = Convert.ToInt32(Console.ReadLine());

Console.Clear(); // Konsol ekranını temizliyoruz

// Dizinin boyutunu kullanıcıdan aldığımız değere göre ayarlıyoruz
int[] EnginDizi = new int[diziBoyutu];

// Kullanıcıdan dizinin elemanlarını alıp diziye atıyoruz 
for (int i = 0; i < diziBoyutu; i++) { 
    Console.Write($"Dizinin {i+1}. Elemanını Giriniz: ");
    EnginDizi[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(); // 1 satır boşluk bırakıyoruz

// Diziyi KÜÇÜKTEN BÜYÜĞE sıralıyoruz
Array.Sort(EnginDizi);

Console.WriteLine("KÜÇÜKTEN BÜYÜĞE SIRALANMIŞ DİZİ: ");
foreach (int eleman in EnginDizi)
{
    // Dizinin elemanlarını ekrana yazdırıyoruz
    Console.Write(eleman + " ");
}

Console.WriteLine(); // 1 satır boşluk bırakıyoruz

// Diziyi BÜYÜKTEN KÜÇÜĞE sıralıyoruz
Array.Reverse(EnginDizi); // Diziyi ters çeviriyoruz (BÜYÜKTEN KÜÇÜĞE sıralamak için)

Console.WriteLine("BÜYÜKTEN KÜÇÜĞE SIRALANMIŞ DİZİ: ");
foreach (int eleman2 in EnginDizi)
{
    // Dizinin elemanlarını ekrana yazdırıyoruz
    Console.Write(eleman2 + " ");
}


Console.ReadLine(); // Konsol ekranında kalmasını sağlıyoruz (kapanmaması için)