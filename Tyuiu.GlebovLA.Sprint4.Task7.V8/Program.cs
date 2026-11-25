using System;
using Tyuiu.GlebovLA.Sprint4.Task7.V8.Lib;

namespace Tyuiu.GlebovLA.Sprint4.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Глебов Л. А. | ПКТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"264795863157\".                     *");
            Console.WriteLine("* Преобразуйте ее в матрицу 3 на 4 и подсчитайте сумму нечетных чисел.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            string str = "264795863157";
            int rows = 3;
            int cols = 4;

            Console.WriteLine($"* Строка: {str}");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");

            DataService ds = new DataService();
            int res = ds.Calculate(rows, cols, str);

            Console.WriteLine($"* Сумма нечетных чисел = {res}");
            Console.ReadKey();
        }
    }
}