namespace DaireCizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yaricap;
            double kalinlik = 0.4;

            Console.Write("Yarıçapını giriniz: ");
            if (!double.TryParse(Console.ReadLine(), out yaricap) || yaricap <= 0)
            {
                Console.WriteLine("Yarıçapta negatif değer girilemez !!");
                return;
            }

            while (yaricap <= 0) ;

            Console.WriteLine();
            double rin = yaricap - kalinlik, rOut = yaricap + kalinlik;

            for (double y = yaricap; y >= -yaricap; --y)
            {
                for (double x = -yaricap; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rin * rin && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}