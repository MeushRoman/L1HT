using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1ht
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintArr();
            //IndexMaxArr();
            //IndexMaxEvenNumb();
            //RemoveElemByIndex(0);
            //RemoveElemByNum(6);
            //InsertElemByIndex(6, 5);
            StringOne("aldkjh hsdflksh one");
        }

        //•	Напечатать весь массив целых чисел
        static void PrintArr()
        {
            int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write("{0} ", Arr[i]);
            }
            Console.WriteLine("\n");
        }

        //•	Напечатать весь массив целых чисел
        static void IndexMaxArr()
        {
            int[] Arr = { 1, 2, 12, 4, 5, 6 };

            Console.WriteLine("Индекс максимального значения = {0}", Array.IndexOf(Arr, Arr.Max()));
        }

        //•	Найти индекс максимального четного значения в массиве
        static void IndexMaxEvenNumb()
        {
            int[] Arr = { 1, 2, 200, 4, 5, 6, 7, 8, 9 };
            int Max = Arr.Min();

            for (int i = 0; i < Arr.Length; i++)
            {
                if ((Arr[i] > Max) && (Arr[i] % 2 == 0))
                {
                    Max = Arr[i];
                }
            }
            Console.WriteLine(Array.IndexOf(Arr, Max));
        }

        //•	Удалить элемент из массива по индексу.
        static void RemoveElemByIndex(int Index)
        {
            int[] Arr = { 5, 2, 3, 4, 5, 6 };

            Arr = Arr.Where((source, index) => index != Index).ToArray();

            for (int i = 0; i < Arr.Length; i++)
                Console.Write("{0} ", Arr[i]);
        }

        //•	Удаление элементов из массива по значению
        static void RemoveElemByNum(int Num)
        {
            int[] Arr = { 5, 2, 3, 4, 5, 6 };

            Arr = Arr.Where(elem => elem != Num).ToArray();

            for (int i = 0; i < Arr.Length; i++)
                Console.Write("{0} ", Arr[i]);
        }

        // •	Вставить элемент в массив по индексу
        static void InsertElemByIndex(int Index, int Numb)
        {
            int[] Arr = { 5, 2, 3, 4, 5, 6 };
            int[] tmp = new int[Arr.Length + 1];

            if (Index < tmp.Length)
            {
                for (int i = 0, j = 0; j < tmp.Length; i++, j++)
                {
                    if (j == Index)
                    {
                        tmp[j] = Numb;
                        Console.Write("{0} ", tmp[j]);
                        i--;
                        continue;
                    }
                    tmp[j] = Arr[i];
                    Console.Write("{0} ", tmp[j]);
                }
            }
        }

        //•	Дан текст. Определить, есть ли в тексте слово one.
        static void StringOne(string str)
        {
            if (str.Contains("one"))
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }
    }
}
