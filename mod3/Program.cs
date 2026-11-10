using System;
using System.Numerics;

namespace mod3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Расчет факториала =>\nВведите число:");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int input) && input >= 0 && input <= 100)
                {
                    Console.WriteLine($"\n{Ffactorial(input)}");
                    Console.WriteLine($"\n{Rfactorial(input)}");
                    break;
                }
                Console.WriteLine("Введите целое число от 0 до 100!");
            }
        }
        private static BigInteger Rfactorial(int n) => n <= 1 ? 1 : n * Rfactorial(n - 1);

        private static BigInteger Ffactorial(int n)
        {
            BigInteger res = 1;
            for (int i = 1; i <= n; i++)
                res *= i;
            return res;
        }

    }
}