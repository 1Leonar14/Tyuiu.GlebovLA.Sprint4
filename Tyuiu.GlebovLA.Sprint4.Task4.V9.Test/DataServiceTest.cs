using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint4.Task4.V9.Lib;

namespace Tyuiu.GlebovLA.Sprint4.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[,] {
                { 3, 7, 3, 1, 5 },
                { 6, 3, 2, 1, 2 },
                { 1, 3, 2, 8, 1 },
                { 5, 8, 1, 5, 1 },
                { 3, 3, 4, 4, 6 }
            };

            int wait = 42;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}