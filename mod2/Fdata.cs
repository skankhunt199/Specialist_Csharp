using System;
using System.Collections.Generic;
using System.Text;

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
        /// <summary>
        /// Структура данных фигуры
        /// </summary>
        /// <param name="x0">Координата по Х</param>
        /// <param name="y0">Координата по У</param>
        /// <param name="color">Цвет</param>
        /// <param name="type">Тип фигуры</param>
        public Fdata(int x0, int y0, int color, Figures type)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.color = color;
            this.type = type;
        }
    }
}
