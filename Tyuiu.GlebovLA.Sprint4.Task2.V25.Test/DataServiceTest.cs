using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint4.Task2.V25.Lib;

namespace Tyuiu.GlebovLA.Sprint4.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 4, 3, 5, 6, 7, 8, 9, 4, 5, 3, 4 };

            int wait = 3072;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}