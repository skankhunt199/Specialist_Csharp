using System;
using System.Drawing;

namespace mod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = new Fdata
            {
                radius = 5,
                color = 0x272FF,
                type = Figures.Circle
            };
            Console.WriteLine(circle);
            Console.WriteLine($"\tПлощадь: s={Area(circle):0.##}");
            Console.WriteLine();

            var rect = new Fdata
            {
                a = 5,
                b= 10,
                color = 0x272FF,
                type = Figures.Rect
            };
            Console.WriteLine(rect);
            Console.WriteLine($"\tПлощадь: s={Area(rect):0.##}");
            Console.WriteLine();

            var romb = new Fdata
            {
                radius = 5,
                a = 3,
                color = 0x272FF,
                type = Figures.Romb
            };
            Console.WriteLine(romb);
            Console.WriteLine($"\tПлощадь: s={Area(romb):0.##}");
            Console.WriteLine();
        }

        
        private static double Area(Fdata fdata)
        {
            double res = 0;
            switch (fdata.type)
            {
                case Figures.Romb:
                    res = 2 * fdata.a * fdata.radius;
                    break;
                case Figures.Circle:
                    res = Math.PI * fdata.radius * fdata.radius;
                    break;
                case Figures.Rect:
                    res = fdata.a * fdata.b;                    
                    break;
                default:
                    break;
            }
            return res;
        }
    }
}
