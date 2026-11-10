namespace mod2
{
    internal struct Fdata
    {
        // координаты центра тяжести
        public int x0, y0;
        // цвет фигуры
        public int color;
        // тип фигуры
        public Figures type;
        // стороны
        public double a, b;
        // радиус
        public double radius;
        public override string ToString() =>
            $"\n Фигура: {type}\n\tЦентр тяжести: x={x0}, y={y0}\n\tСтороны: a={a}, b={b}\n\tРадиус: {radius}\n\tЦвет: {color}\n";

    }
}
