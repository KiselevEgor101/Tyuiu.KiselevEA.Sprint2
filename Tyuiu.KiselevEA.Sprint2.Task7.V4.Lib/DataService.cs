using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KiselevEA.Sprint2.Task7.V4.Lib
{
    public class DataService : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            if((Math.Pow(x,2) + Math.Pow(y,2) <= 1) && ((x > 0.3) && (x <= 1)) && ((y <=1) && (y >= -1)))
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
