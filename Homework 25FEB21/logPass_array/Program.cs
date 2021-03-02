using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace logPass
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

            /*ПАТАРУШИН
            4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
            */


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Account granted = new Account("root", "GeekBrains");
            bool authorizaion = false;
            string[] array = Read_from_File("log_passes.txt");
            for (int i = 0; i < array.Length; i += 1)
            {
                Console.WriteLine(array[i]);
            }

                for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] == granted.login  && array[i + 1] == granted.password)
                {
                    Console.WriteLine($"Авторизация прошла успешно на паре #{i/2 + 1}!");
                    authorizaion = true;
                    break;
                }
                else
                {
                    Console.WriteLine($"Ошибка авторизации пары #{i / 2 + 1}!");
                }
            }

            if (authorizaion == true)
            {
                Console.WriteLine("\n\nДобро пожаловать");
            }
            else
            {
                Console.WriteLine("\n\nОбратитесь к администратору для восстановления доступа");
            }

            Console.ReadLine();

        }
    }
}
