using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib
{
    public class Triangle
    {
        public double side1, side2, side3;
        public List<double> elements;

        public Triangle(List<double> elements)
        {
            this.elements = elements;
        }

        public void GetArea()
        {
            elements.Sort(); //Сортировка элементов списка по возрастанию для того чтобы определить самую боьшую сторону. Она будет вероятной гипотенузой при проверке на прямоугольность.
            side1 = elements[0];
            side2 = elements[1];
            side3 = elements[2];
            string right;
            double half_perim = (side1 + side2 + side3) / 2; //Вычисление полупериметра
            double area = Math.Sqrt(half_perim * (half_perim - side1) * (half_perim - side2) * (half_perim - side3)); //Вычисление площади
            if (side3 * side3 == side1 * side1 + side2 * side2) //Проверка на прямоугольность по теореме Пифагора
            {
                right = "Треугольник прямоугольный";
            }
            else
            {
                right = "Треугольник не прямоугольный";
            }
            Console.WriteLine($"Площадь треугольника {Math.Round(area, 2)} {right}");
        }
    }
}
