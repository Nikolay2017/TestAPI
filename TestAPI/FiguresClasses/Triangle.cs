using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.FiguresClasses
{
    public class Triangle : Figure
    {
        private double side1, side2, side3;   // Стороны треугольника

        // Конструктор
        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        // Свойство, проверяем значение на отрицательность.
        // Если значение отрицательное меняем его на аналогичное положительное.
        public double Side1
        {
            get => side1;
            set => side1 = value < 0 ? -value : value;
        }

        public double Side2
        {
            get => side2;
            set => side2 = value < 0 ? -value : value;
        }

        public double Side3
        {
            get => side3;
            set => side3 = value < 0 ? -value : value;
        }

        public override double Area()
        {
            //Формула Герона
            //S= √ (p * (p - a)*(p - b)*(p - c)) ,где
            //S - площадь;
            //p - полупериметр треугольника(a + b + c) / 2;
            //a,b,c - длины сторон треугольника.

            var p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public bool RightTriangle()
        {
            if ((Side1 * Side1 == Side2 * Side2 + Side3 * Side3) || (Side2 * Side2 == Side1 * Side1 + Side3 * Side3) || (Side3 * Side3 == Side1 * Side1 + Side2 * Side2))
                return true;
            return false;
        }
    }
}
