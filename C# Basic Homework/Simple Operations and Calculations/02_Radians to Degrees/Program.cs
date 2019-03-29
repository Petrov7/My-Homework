using System;

namespace P01_UsdToBgn
{
    public class Program
    {
        public static void Main()
        {
            double rad = double.Parse(Console.ReadLine());
            double degree = rad * 180 / Math.PI;

            Console.WriteLine($"{degree:f0}");
        }
    }
}
