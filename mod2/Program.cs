namespace mod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var figure = new Fdata(1, 1, 0x2727FF, Figures.Romb);
            Console.WriteLine($"Координаты центра тяжести: х0={figure.x0}, y0={figure.y0}, цвет: {figure.color}, тип: {figure.type}");
        }
    }
}
