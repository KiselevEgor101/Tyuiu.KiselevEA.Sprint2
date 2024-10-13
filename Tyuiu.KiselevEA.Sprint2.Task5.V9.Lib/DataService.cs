using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KiselevEA.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            if ((m % 2 != 0 && n == 30) || (m % 2 == 0 && n == 31) || (m == 2 && n == 28))
            {
                m++;
            }
            if ((m < 9) || (m % 2 == 0 && m == 30) || (m % 2 != 0 && m == 31) || (m == 3 && m == 28))
            {
                switch (m)
                {
                    case 1: return $"0{m + 1}.0{n}";
                    case 2: return $"0{n % 30 + 1}.0{n}";
                    case 3: return $"0{m % 28 + 1}.0{n}";
                    case 4: return $"0{m % 30 + 1}.0{n}";
                    case 5: return $"0{m % 31 + 1}.0{n}";
                    case 6: return $"0{m % 30 + 1}.0{n}";
                    case 7: return $"0{m % 31 + 1}.0{n}";
                    case 8: return $"0{m % 30 + 1}.0{n}";
                    case 9: return $"0{m % 31 + 1}.0{n}";
                    case 10: return $"0{m % 30 + 1}.{n}";
                    case 11: return $"0{m % 31 + 1}.{n}";
                    case 12: return $"0{m % 30 + 1}.{n}";
                    default: throw new ArgumentException("31 декабря недоступно.");
                }
            }
            else
            {
                switch (n)
                {
                    case 1: return $"{m + 1}.0{n}";
                    case 2: return $"{m % 30 + 1}.0{n}";
                    case 3: return $"{m % 28 + 1}.0{n}";
                    case 4: return $"{m % 30 + 1}.0{n}";
                    case 5: return $"{m % 31 + 1}.0{n}";
                    case 6: return $"{m % 30 + 1}.0{n}";
                    case 7: return $"{m % 31 + 1}.0{n}";
                    case 8: return $"{m % 30 + 1}.0{n}";
                    case 9: return $"{m % 31 + 1}.0{n}";
                    case 10: return $"{m % 30 + 1}.{n}";
                    case 11: return $"{m % 31 + 1}.{n}";
                    case 12: return $"{m % 30 + 1}.{n}";
                    default: throw new ArgumentException("31 декабря недоступно.");

                }
            }
        }
    }
}
