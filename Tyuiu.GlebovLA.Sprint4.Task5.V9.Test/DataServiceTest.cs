using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint4.Task5.V9.Lib;

namespace Tyuiu.GlebovLA.Sprint4.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[,] {
                { 3, -2, 1, 0, -4 },
                { -1, 2, -3, 4, -2 },
                { 0, 1, -1, 2, 3 },
                { -4, 3, -2, 1, 0 },
                { 2, -1, 0, -3, 4 }
            };

            int wait = 11;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}