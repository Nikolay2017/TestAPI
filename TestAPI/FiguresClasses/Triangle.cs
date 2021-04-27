using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.FiguresClasses
{
    public class Triangle : Figure
    {
        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
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
