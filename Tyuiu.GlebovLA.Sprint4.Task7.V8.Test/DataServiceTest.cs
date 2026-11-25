using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint4.Task7.V8.Lib;

namespace Tyuiu.GlebovLA.Sprint4.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int rows = 3;
            int cols = 4;
            string str = "264795863157";

            int wait = 27;
            int res = ds.Calculate(rows, cols, str);

            Assert.AreEqual(wait, res);
        }
    }
}