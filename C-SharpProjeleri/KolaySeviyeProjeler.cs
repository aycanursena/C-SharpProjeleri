using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpProjeleri
{
    internal class KolaySeviyeProjeler
    {
        public void TerstenYazdır()
        {
            Console.Write("Bir ifade giriniz : ");
            string input = Console.ReadLine();

            string[] kelime = input.Split(' ');

            foreach(string s in kelime)
            {
                for (int i = 1; i < s.Length; i++)
                {
                    Console.Write(s[i]);
                }
                Console.Write(s[0] + " ");
            }
        }

        public void Algoritma()
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
