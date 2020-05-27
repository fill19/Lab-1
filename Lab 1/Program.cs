using System;

namespace Lab_1
{
    public class Program
    {
        public static double fs(int x)
        {
            return Math.Pow(x, 3) - 4 * Math.Pow(x, 2) - 5 * x + 9 + Math.Cos(x);
        }

        static void Main(string[] args)
        {
            int x = 0;
            Console.Write("y = ");
            Console.WriteLine(fs(x));
            Console.ReadKey();

        }
    }
}
