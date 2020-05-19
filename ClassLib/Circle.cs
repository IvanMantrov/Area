using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib
{
    public class Circle
    {
        public double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public void GetArea()
        {
            double area = radius * radius * Math.PI;
            Console.WriteLine($"Площадь круга: {Math.Round(area, 2)}");
        }
    }
}
