using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GlebovLA.Sprint4.Task6.V24.Lib;

namespace Tyuiu.GlebovLA.Sprint4.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };

            string[] wait = { "Компьютер", "Клавиатура" };
            string[] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}