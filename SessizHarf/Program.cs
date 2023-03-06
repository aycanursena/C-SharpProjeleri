using System.Text;

namespace SessizHarf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sessizHarf = "bcdfgğhjklmnprsştvyz";
            bool yanYana = false;
            bool sayiMi = false;

            Console.Write("Bir cümle giriniz : ");
            string input = Console.ReadLine();
            string[] kelimeler = input.Split(' ');

            foreach(string kelime in kelimeler)
            {
                try
                {
                    int.Parse(kelime);
                    sayiMi = true;
                    continue;
                }
                catch (Exception)
                {
                    sayiMi = false;   
                }

                if (sayiMi == false)
                {
                    for (int i = 0; i < kelime.Length; i++)
                    {
                        if (i == (kelime.Length - 1))
                        {
                            yanYana = false;
                            break;
                        }
                        if (sessizHarf.Contains(kelime[i]) && sessizHarf.Contains(kelime[i + 1]))
                        {
                            yanYana = true;
                            break;
                        }
                    }
                    Console.Write(yanYana + " ");
                }
            }
        }
    }
}