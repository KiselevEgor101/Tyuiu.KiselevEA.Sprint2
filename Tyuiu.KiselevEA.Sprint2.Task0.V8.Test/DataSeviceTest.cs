// Ќаписать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушатьс€) и
// арифметических выражений, котора€ вернет логическую последовательность(массив):
// (True, False, True, False, True, False),
// при x = 185, y = 251


using Tyuiu.KiselevEA.Sprint2.Task0.V8.Lib;

namespace Tyuiu.KiselevEA.Sprint2.Task0.V8.Test
{
    [TestClass]
    public class DataSeviceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 185;
            int y = 251;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}