using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.FiguresClasses
{
    public class Circle : Figure
    {
        private double radius;   // Радиус круга

        // Конструктор
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Свойство, проверяем значение на отрицательность.
        // Если значение отрицательное меняем его на аналогичное положительное.
        public double Radius
        {
            get => radius;
            set => radius = value < 0 ? -value : value;
        }

        public override double Area()
        {
            //S = PR^2

            return Math.PI * Radius * Radius;
        }
    }
}
