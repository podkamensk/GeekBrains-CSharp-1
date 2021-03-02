using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1d
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            /* ПАТАРУШИН
            1.  Дан целочисленный  массив из 20 элементов.Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.
                Заполнить случайными числами.Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только 
                одно число делится на 3.В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива 
                из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
            2. Реализуйте задачу 1 в виде статического класса StaticClass;
            а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
            б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
            в)**Добавьте обработку ситуации отсутствия файла на диске.       
          
            а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив определенного размера 
            и заполняющий массив числами от начального значения с заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива,
            метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),  метод Multi, 
            умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
            б)**Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
            е) ***Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary< int,int>)
              */



            int[] array = new int[20];

            #region Пишем массив рандомный целых в файл, потом чистим массив
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                array[i] = rnd.Next(-10000, 10001);
            }
   
            Array_1d.Array_to_File("array_here.md", array);
            Array.Clear(array, 0, array.Length);
            #endregion

            #region Достаем 1d массив целых чисел из файла
            array = Array_1d.Read_from_File("array_here.md");
            Console.WriteLine("Массив из файла:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            #endregion

            //Проверка метода Multi
            Console.WriteLine("Массив после MULTI на 3:");
            int[] array_mult = Array_1d.Multi(array, 3);
            for (int i = 0; i < array_mult.Length; i++)
            {
                Console.WriteLine(array_mult[i]);
            }

            //Проверка метода INVERSE
            Console.WriteLine("Массив после Inverse:");
            int[] array_inv = Array_1d.Inverse(array);
            for (int i = 0; i < array_inv.Length; i++)
            {
                Console.WriteLine(array_inv[i]);
            }

            Console.WriteLine($"\nЧисло искомых пар: {Array_1d.Pair_Count_Array(array)}");
            Console.ReadLine();
        }
    }
}
