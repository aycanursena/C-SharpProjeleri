namespace Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sayiMi = false;
            int x = 0;
            Console.Write("Bir kelime ve bir sayı giriniz (aralarında virgül ile) : ");
            string input = Console.ReadLine();

            string[] girilenDeger = input.Split(',');
            List<int> sayilar = new List<int>();
            List<string> kelimeler = new List<string>();

            foreach (var item in girilenDeger)
            {
                try
                {
                    int a = int.Parse(item);
                    sayilar.Add(a);
                    sayiMi = true;
                }
                catch (Exception)
                {
                    kelimeler.Add(item);
                }
            }

            foreach (string kelime in kelimeler)
            {
                for (int i = 0; i < kelime.Length; i++)
                {
                    if (i == sayilar[x])
                    {
                        kelime.Remove(i);
                        continue;
                    }
                    Console.Write(kelime[i]);
                }
                x++;
                Console.WriteLine();
            }
        }
    }
}