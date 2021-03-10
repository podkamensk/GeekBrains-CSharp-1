using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MinFunc
{
    public delegate double Functions(double x, double a, double b);


    class Program
    {
        public static double Func_1(double x, double b, double c)
        {
            return x*x + b*x + c;
        }

        public static double Func_2(double x, double a, double b)
        {
            return a*Math.Sin(b*x);
        }

        public static double Func_3(double x, double k, double b)
        {
            return k*x + b;
        }

        public static double Func_4(double x, double c, double d)
        {
            return x*x*x + x*x + c*x + d;
        }

        public static void SaveFunc(string fileName, Functions func, double param_a, double param_b, double range_start, double range_end, double step)
        //Saves resuts of a function in range of X to the file
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = range_start;
            while (x <= range_end)
            {
                bw.Write(func(x, param_a, param_b));
                x += step;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        public static double Load(string fileName)
        //Reads the results from file, then returns min value
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }


        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //Создаем массив делегатов
            Functions[] array = new Functions[4];
            array[0] = new Functions(Func_1);
            array[1] = new Functions(Func_2);
            array[2] = new Functions(Func_3);
            array[3] = new Functions(Func_4);

            //Запрашиваем выбор функции
            Console.WriteLine("Выберите функцию (1-4):");
            Console.WriteLine("1. Квадратная");
            Console.WriteLine("2. Синусоида");
            Console.WriteLine("3. Линейная");
            Console.WriteLine("3. Кубическая");
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;

            //Запрашиваем параметры функции - пока просто тест.
            Console.Write("Укажите параметр функции a");
            double par_a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите параметр функции b");
            double par_b = Convert.ToDouble(Console.ReadLine());


            //Запрашиваем диапазоны
            Console.Write("Укажите начало диапазона поиска минимума");
            double range_start = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите конец диапазона поиска минимума");
            double range_end = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите шаг");
            double st = Convert.ToDouble(Console.ReadLine());

            //Модернизируем SaveFunc, чтобы принимала фйнкцию из массива и запускаем вычисления
            SaveFunc("data.bin", array[choice], par_a, par_b, range_start, range_end, st);
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();

        }
    }
}
