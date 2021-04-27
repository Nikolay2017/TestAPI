using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.FiguresClasses;

namespace TestAPI.Services
{
    public class AreaCalculationService
    {
        public double AreaCalculation(string type, double side1, double side2, double side3)
        {
            Figure figure = null;
            switch (type)
            {
                case "Circle":
                    figure = new Circle(side1);
                    break;
                case "Triangle":
                    figure = new Triangle(side1, side2, side3);
                    break;
            }
            return figure != null ? figure.Area() : 0;
        }
    }
}
