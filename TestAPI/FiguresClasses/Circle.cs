using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.FiguresClasses
{
    public class Circle : Figure
    {
        public Circle(double side1)
        {
            Side1 = side1;
        }

        public override double Area()
        {
            //S = PR^2

            return Math.PI * Side1 * Side1;
        }
    }
}
