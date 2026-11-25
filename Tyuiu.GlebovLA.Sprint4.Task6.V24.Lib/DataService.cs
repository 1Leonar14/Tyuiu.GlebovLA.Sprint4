using System;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GlebovLA.Sprint4.Task6.V24.Lib
{
    public class DataService : ISprint4Task6V24
    {
        public string[] Calculate(string[] array)
        {
            return Array.FindAll(array, s => s.Length > 7);
        }
    }
}