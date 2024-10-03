// Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) и
// арифметических выражений, которая вернет логическую последовательность(массив):
// (True, False, True, False, True, False),
// при x = 185, y = 251


using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KiselevEA.Sprint2.Task0.V8.Lib
{
    public class DataService : ISprint2Task0V8
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 66 == y; // true
            res[1] = x + 66 != y; // false
            res[2] = x < y; // true
            res[3] = x + 5 > y; // false
            res[4] = x <= y; // true
            res[5] = x + 13 >= y; // false
            return res;
        }
    }
}
