//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один
//раз в выражении) и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также
//арифметических выражений, которая вернет логическую последовательность(массив): 
//(True, False, False, False, False, False),
//при a = 185, b = 316, c = 134, d = 134
using Tyuiu.KiselevEA.Sprint2.Task1.V3.Lib;
namespace Tyuiu.KiselevEA.Sprint2.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int a = 185;
            int b = 316;
            int c = 134;
            int d = 134;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, false, false, false, false, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}