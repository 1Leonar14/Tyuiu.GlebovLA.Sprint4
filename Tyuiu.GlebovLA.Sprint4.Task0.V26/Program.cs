using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GlebovLA.Sprint4.Task0.V26.Lib;

namespace Tyuiu.GlebovLA.Sprint4.Task0.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Глебов Л.А. | ПКТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму нечетных *");
            Console.WriteLine("* элементов массива. {9 ,3 ,7 ,1 ,5 ,5 ,3 ,2 ,1 ,7}                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int[] array = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            DataService ds = new DataService();
            int res = ds.GetSumOddArrEl(array);

            Console.WriteLine($"Сумма нечетных элементов массива = {res}");
            Console.ReadKey();
        }
    }
}