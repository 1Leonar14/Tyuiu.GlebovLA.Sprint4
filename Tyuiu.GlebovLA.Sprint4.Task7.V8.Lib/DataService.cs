using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GlebovLA.Sprint4.Task7.V8.Lib
{
    public class DataService : ISprint4Task7V8
    {
        public int Calculate(int rows, int cols, string str)
        {
            int[,] matrix = new int[rows, cols];
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(str[i * cols + j].ToString());

                    if (matrix[i, j] % 2 != 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            return sum;
        }
    }
}