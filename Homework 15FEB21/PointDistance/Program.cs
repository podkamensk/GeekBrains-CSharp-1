using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointDistance
{
    class Program
    {
        /* ПАТАРУШИН
        3. а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
           б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
        */

        static double Points_distance(double x_1, double y_1, double x_2, double y_2)
        {
            return Math.Sqrt(Math.Pow(x_1 - x_2, 2) + Math.Pow(y_1 - y_2, 2));
        }
        


        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double x1;
            double y1;
            double x2;
            double y2;

            //User input
            Console.WriteLine("Введите координаты первой точки:");
            Console.Write("X = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y = ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты второй точки:");
            Console.Write("X = ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y = ");
            y2 = Convert.ToDouble(Console.ReadLine());

            //calculation and output
            Console.WriteLine("Расстояние между точкой [{0:f2}, {1:f2}] и точкой [{2:f2}, {3:f2}] составляет {4:f2}", x1, y1, x2, y2, Points_distance(x1, y1, x2, y2));
            Console.ReadLine();


        }
    }
}
