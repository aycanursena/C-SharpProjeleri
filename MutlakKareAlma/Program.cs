namespace MutlakKareAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı giriniz: ");
            string sayilar = Console.ReadLine();
            string[] sayiListesi = sayilar.Split(' ');

            int toplam = 0;
            double mutlakToplam = 0;

            foreach (var sayi in sayiListesi)
            {
                int x = int.Parse(sayi);
               
                if(x < 67)
                {
                    int y = 67 - x;
                    toplam += y;
                }
                else
                {
                    double a = Math.Pow(x - 67, 2);   
                    mutlakToplam += a;
                }
            }

            Console.Write(toplam + " " + mutlakToplam);
        }
    }
}