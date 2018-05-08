using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину 1 стороны прямоугольника: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину 2 стороны прямоугольника: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Area = {0}, Perimeter = {1}", rectangle.Area, rectangle.Perimeter);

            // Delay
            Console.ReadKey();
        }
    }
}
