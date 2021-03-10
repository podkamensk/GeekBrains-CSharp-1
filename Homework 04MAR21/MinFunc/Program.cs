using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public delegate double Funс(double x);



namespace MinFunc
{
    class Program
    {
        public static double Func_Quadratic(double x, double a, double b, double c)
        {
            return a*x*x + b*x + c;
        }

        public static double Func_Sin(double x, double a, double b, double phase)
        {
            return a*Math.Sin(b*x + phase);
        }

        public static double Func_Linear(double x, double k, double b)
        {
            return k*x + b;
        }

        public static double Func_Cubic(double x, double a, double b, double c, double d)
        {
            return a*x*x*x + b*x*x + c*x + d;
        }


        public static void SaveFunc(string fileName, double a, double b, double h)
        //Saves resuts of a function in range of X to the file
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
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

            SaveFunc("data.bin", -100, 100, 0.5);
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();

        }
    }
}
