// x = 3 y=3
// x = 13 y =6
// x = 3 y =11
// x= 12 y=12

using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KiselevEA.Sprint2.Task2.V24.Lib
{
    public class DataService : ISprint2Task2V24
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3) && (x <= 13) && (y >= 3) && (y <= 6))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
