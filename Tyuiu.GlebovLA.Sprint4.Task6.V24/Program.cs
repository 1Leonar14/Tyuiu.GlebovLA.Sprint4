using System;
using Tyuiu.GlebovLA.Sprint4.Task6.V24.Lib;

namespace Tyuiu.GlebovLA.Sprint4.Task6.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Глебов Л. А. | ПКТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Глебов Леонид Александрович | ПКТб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Компьютер, Телефон, Планшет,               *");
            Console.WriteLine("* Принтер, Сканер, Монитор, Клавиатура], используя класс Array,           *");
            Console.WriteLine("* выведите элементы массива, длина которых больше 7 символов.             *");
            Console.WriteLine("***************************************************************************");
            string[] array = { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };

            Console.WriteLine("* Исходный массив:                                                        *");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"* {array[i]}");
            }
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            DataService ds = new DataService();
            string[] res = ds.Calculate(array);
            Console.WriteLine("* Элементы, длина которых больше 7 символов:                              *");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"* {res[i]}");
            }
            Console.ReadKey();
        }
    }
}