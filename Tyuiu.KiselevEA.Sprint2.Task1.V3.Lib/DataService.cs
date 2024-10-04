//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один
//раз в выражении) и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также
//арифметических выражений, которая вернет логическую последовательность(массив): 
//(True, False, False, False, False, False),
//при a = 185, b = 316, c = 134, d = 134
//




using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KiselevEA.Sprint2.Task1.V3.Lib
{
    public class DataService : ISprint2Task1V3
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a < b) | (b > d); // true
            res[1] = (a == b) & (c < d); // false
            res[2] = (a == c) || (b < d); // false
            res[3] = (c > a) && (a < b); // false
            res[4] = !(res[0]); // false
            res[5] = (a < b) ^ (c == d); // false
            return res;
        }
    }
}
