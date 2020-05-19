using System;
using ClassLib;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Area
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            List<double> elements = new List<double>(); //Список для неопределенного набора значений, вводимых пользователем
            int count = 1;
            for (int i = 0; count > 0; i++) //С помощью цикла вводятся значения до тех пор, пока они соответствуют заданному формату
            {
                Console.WriteLine($"Введите значение для {count}-го элемента. Если ввод не требуется, оставьте строку пустой.");
                string input = Console.ReadLine();
                if (Double.TryParse(input, out double nmb))
                {
                    elements.Add(nmb);
                    count++;
                }
                else
                {
                    break;
                }
            }
            int number_of_elements = elements.Count;
            if (number_of_elements == 1) //Если введено только одно значение, то фигура будет опознана как круг, введенное число будет являться его радиусом
            {
                double radius = elements[0];
                Circle circle = new Circle(radius);
                circle.GetArea();
            }
            else if (number_of_elements == 3) //Если введено три значения, то фигура будет опознана как треугольник, введенные числа будут являться его сторонами
            {
                Triangle triangle = new Triangle(elements);
                triangle.GetArea();
            }
            else
            {
                Console.WriteLine("Фигура не определена");
            }
            /*Исходя из количества заданных параметров, фигура определяется автоматически. Это к вопросу о вычислении площади, когда тип фигуры неизвестен.
            Добавляя конструкции "else if" мы можем задавать признаки, по которым будут определяться другие фигуры исходя из количества сторон.
            А это уже к вопросу о возможности добавления новых фигур*/

            Console.Read();

        }
    }
}

