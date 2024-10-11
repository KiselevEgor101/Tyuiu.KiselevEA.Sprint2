using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KiselevEA.Sprint2.Task3.V13.Lib
{
    public class DataService : ISprint2Task3V13
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 1)
            {
                y = x - Math.Pow(((x + 1) / (x - 1)), x);
            }
            else
            {
                if (x==0)
                {
                    y = (7 * Math.Pow(x, 2) - Math.Pow(Math.Cos(x), 2) + 10) / (8 * Math.Pow(x, 2) - Math.Pow(Math.Sin(x), 2) + 1);
                }
                else
                {
                    if ((x > -17) && (x < 2))
                    {
                        y = Math.Pow(3 + (8 / Math.Pow(x, 2)), x);
                    }
                    else
                    {
                        if (x < - 17)
                        {
                            y = (x + 10 * x - (1 / x));
                        }
                    }
                }

            }
            return Math.Round(y, 3);
        }
    }
}
