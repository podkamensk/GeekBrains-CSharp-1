using System;
using System.IO;


namespace Array1d
{
    static class Array_1d
    {
        
        static public int[] Prefilled_Array_Create(int len, int base_value, int step)  //Я так и не понял, зачем статическому классу конструктор (у него же нет instance'ов!). Сделал пока метордом
        {
            int[] arr = new int[len];
            for (int i = 0; i < len; i += 1)
            {
                arr[i] = base_value + step * i;
            }
            return arr;
        }
        
       static public int[] Multi(int[] ref_arr, int coeff)
            //Creates and returns copy of the input array,where each element is multiplied by input int
        {
            int[] new_arr = new int[ref_arr.Length];
            for (int i = 0; i < new_arr.Length; i += 1)
            {
                new_arr[i] = ref_arr[i] * coeff;
            }

            return new_arr;
        }

        static public int[] Inverse(int[] ref_arr)
        //Creates and returns copy of the input array,where each element has an opposit sign
        {
            return Multi(ref_arr, -1);
        }



        static public int Pair_Count_Array(int[] arr)
        {
            //Returns number of pairs where only one element has div(3) == 0
            int len = arr.Length;
            int counter = 0;

            for (int i = 0; i < len - 1; i++)
            {
                double a, b;
                a = arr[i] % 3;
                b = arr[i + 1] % 3;
                if ((a == 0 && b != 0) || (a != 0 && b == 0))
                {
                    counter += 1;
                }
            }
            return counter;
        }

        static public void Array_to_File(string filename, int[] arr)
        //Writes an 1d array to the file with defined filename
        {
            var len = arr.Length;
            string str = String.Empty;
            for (int i = 0; i < len; i += 1)
            {
                str += Convert.ToString(arr[i]) + " ";
            }
            File.WriteAllText(filename, str);
        }

        static public int[] Read_from_File(string filepath)
        //Converts file content to string
        {
            if (File.Exists(filepath))
            {
                string filestring = File.ReadAllText(filepath);
                string substring = String.Empty;
                int len = filestring.Length;
                int[] arr = new int[1000];   //Нужно задать по-другому. Иначе не сработает с более 1000 элементов
                int arr_count = 0;

                //Ищем пробел, когда находим, наполняем строку тем, что слева
                for (int i = 0, lb = i; i < len; i += 1)
                {
                    if (filestring[i] == ' ')  //Пробел нашли итерируем строку от lb до i, наполняя substring. Потом трайпарсим substring в следующий элемент массива arr
                    {
                        for (int ii = lb; ii < i; ii += 1)
                        {
                            substring += filestring[ii];
                        }

                        if (Int32.TryParse(substring, out arr[arr_count]))
                        {
                            arr_count += 1;
                        }
                        substring = String.Empty;
                        lb = i;
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
    }
}
