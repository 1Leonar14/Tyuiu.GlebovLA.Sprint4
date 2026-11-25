using System;
using Tyuiu.GlebovLA.Sprint4.Task5.V9.Lib;

namespace Tyuiu.GlebovLA.Sprint4.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Глебов Л. А. | ПКТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -4 до 4.                           *");
            Console.WriteLine("* Найти количество положительных элементов.                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int[,] array = new int[5, 5];
            Random rnd = new Random();

            Console.WriteLine("* Массив:                                                                 *");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("*   ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-4, 5);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("                                                      *");
            }
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            DataService ds = new DataService();
            int res = ds.Calculate(array);

            Console.WriteLine($"* Количество положительных элементов = {res}");
            Console.ReadKey();
        }
    }
}