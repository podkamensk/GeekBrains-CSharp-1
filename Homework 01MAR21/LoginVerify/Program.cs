using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Globalization;


namespace LoginVerify
{

    class Program
    {
        static public string[] Read_from_File(string filepath)
        //Converts file content to string (n+0 - login, n+1 - password)
        {
            if (File.Exists(filepath))
            {
                string filestring = File.ReadAllText(filepath);
                string substring = String.Empty;
                int len = filestring.Length;
                string[] arr = new string[1000];   //Нужно задать по-другому. Иначе не сработает с более 1000 элементов
                int arr_count = 0;

                //Ищем пробел, когда находим, наполняем строку тем, что слева
                for (int i = 0, lb = i; i < len; i += 1)
                {
                    if (filestring[i] == ' ')  //Пробел нашли итерируем строку от lb до i, наполняя substring. 
                    {
                        for (int ii = lb; ii < i; ii += 1)
                        {
                            substring += filestring[ii];
                        }

                        arr[arr_count] = substring;
                        arr_count += 1;
                        substring = String.Empty;
                        lb = i + 1;
                    }
                }
                Array.Resize(ref arr, arr_count);
                return arr;
            }
            else
            {
                Console.WriteLine("Файл не найден");
                Console.ReadKey();
                return null;
            }
        }

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            /* ПАТАРУШИН
            1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
            а) без использования регулярных выражений;
            б) **с использованием регулярных выражений.
             */

            string filedir = "login_list.txt";
            int min_len = 2;
            int max_len = 10;
            string[] log_array;

            log_array = Read_from_File(filedir);

            //ПРОВЕРКА БЕЗ REGEX
            for (int i = 0; i < log_array.Length; i += 1)
            {
                Console.Write($"{log_array[i]} :     ");

                char c = log_array[i][0];  //первый знак
                int login_len = 0;
                if (!Char.IsDigit(c))
                {
                    for (int ch = 0; ch < log_array[i].Length; ch += 1)  //Отметем кириллицу и спецсимволы. Ап: кириллицу так не отмести
                    {
                        login_len += Convert.ToInt32(char.IsLetterOrDigit(log_array[i][0]));
                    }
                }

                // Проверяем сразу на все 4 условия (длина МИH, МАКС, все чары - буквы или цифры, первый чар - не цифра)
                if (log_array[i].Length >= min_len && log_array[i].Length <= max_len && login_len == log_array[i].Length && !Char.IsDigit(c))
                {
                    Console.WriteLine("Логин может быть использован");
                }
                else
                {
                    Console.WriteLine("Формат логина некорректен");
                }

            }

            Console.ReadKey();
            Console.Write("\n\n\n");

            //ПРОВЕРКА С REGEX
            Regex verifier = new Regex("^[a-zA-Z][a-zA-Z0-9]{1, 9}");

            for (int i = 0; i < log_array.Length; i += 1)
            {
                Console.Write($"{log_array[i]} :     ");

                if (verifier.IsMatch(log_array[i]))
                {
                    Console.WriteLine("Логин может быть использован");
                }
                else
                {
                    Console.WriteLine("Формат логина некорректен");
                }
            }

            Console.ReadKey();
        }
    }
}
