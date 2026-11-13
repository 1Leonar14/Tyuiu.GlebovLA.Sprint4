using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint4.Task0.V26.Lib;

namespace Tyuiu.GlebovLA.Sprint4.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumOddArrEl()
        {
            DataService ds = new DataService();

            int[] array = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };

            int wait = 41;
            int res = ds.GetSumOddArrEl(array);

            Assert.AreEqual(wait, res);
        }
    }
}