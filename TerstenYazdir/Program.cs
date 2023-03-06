namespace TerstenYazdir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir ifade giriniz : ");
            string input = Console.ReadLine();

            string[] kelime = input.Split(' ');

            foreach (string s in kelime)
            {
                for (int i = 1; i < s.Length; i++)
                {
                    Console.Write(s[i]);
                }
                Console.Write(s[0] + " ");
            }
        }
    }
}