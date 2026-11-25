using System;
using Tyuiu.GlebovLA.Sprint4.Task3.V1.Lib;

namespace Tyuiu.GlebovLA.Sprint4.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Глебов Л. А. | ПКТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 9. Найдите сумму элементов  *");
            Console.WriteLine("* в последнем столбце массива.                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int[,] array = new int[,] {
                { 3, 4, 3, 4, 1 },
                { 8, 1, 6, 6, 9 },
                { 9, 8, 5, 1, 3 },
                { 1, 8, 7, 1, 2 },
                { 9, 9, 7, 5, 6 }
            };

            Console.WriteLine("* Массив:                                                                 *");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("*   ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("                                                      *");
            }
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            DataService ds = new DataService();
            int res = ds.Calculate(array);

            Console.WriteLine($"* Сумма элементов в последнем столбце = {res}");
            Console.ReadKey();
        }
    }
}