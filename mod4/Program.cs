using System.Text;

namespace mod4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            foreach (var arg in args)
            {
                if(int.TryParse(arg, out var value))                
                    sum += value;                               
            }
            Console.WriteLine($"Входные параметры: {string.Join(',', args)}");
            Console.WriteLine($"Сумма чисел: {sum}");
            Console.WriteLine($"Двоичное представление: {IntToBinary(sum)}");
        }

        private static string IntToBinary(int num)
        {
            var sb = new StringBuilder(35);
            for (int i = 0; i < 32; i++)
            {                
                sb.Append((num & 1) == 1 ? '1' : '0');                
                num >>= 1;                
                if (i == 7 || i == 15 || i == 23)
                    sb.Append(' ');
            }
            return sb.ToString();
        }
    }
}
