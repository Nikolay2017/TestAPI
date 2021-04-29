using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.FiguresClasses;

namespace TestAPI.Services
{
    public class AreaCalculationService
    {
        public double AreaCalculation(string type, List<double> sides)
        {
            Figure figure = null;
            switch (type)
            {
                case "Circle":
                    if (sides.Count == 1)
                        figure = new Circle(sides[0]);
                    break;
                case "Triangle":
                    if (sides.Count == 3)
                        figure = new Triangle(sides[0], sides[1], sides[2]);
                    break;
            }
            return figure != null ? figure.Area() : 0;
        }
    }
}
