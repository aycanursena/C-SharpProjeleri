namespace UcgenCizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz : ");
            int inp = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < inp; i++)
            {
                for (int a = 0; a <= i; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}