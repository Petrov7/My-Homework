using System;

namespace P01_UsdToBgn
{
    public class Program
    {
        public static void Main()
        {
            double usd = int.Parse(Console.ReadLine());
            double bgn = 1.79549;
            double convert = usd * bgn;

            Console.WriteLine($"{convert:f2}");
        }
    }
}
