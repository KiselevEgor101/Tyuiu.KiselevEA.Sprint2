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
            if ((n < 9) || (m % 2 == 0 && n == 30) || (m % 2 != 0 && n == 31) || (m == 3 && n == 28))
            {
                switch (m)
                {
                    case 1: return $"0{n + 1}.0{m}";
                    case 2: return $"0{n % 30 + 1}.0{m}";
                    case 3: return $"0{n % 28 + 1}.0{m}";
                    case 4: return $"0{n % 30 + 1}.0{m}";
                    case 5: return $"0{n % 31 + 1}.0{m}";
                    case 6: return $"0{n % 30 + 1}.0{m}";
                    case 7: return $"0{n % 31 + 1}.0{m}";
                    case 8: return $"0{n % 30 + 1}.0{m}";
                    case 9: return $"0{n % 31 + 1}.0{m}";
                    case 10: return $"0{n % 30 + 1}.{m}";
                    case 11: return $"0{n % 31 + 1}.{m}";
                    case 12: return $"0{n % 30 + 1}.{m}";
                    default: throw new ArgumentException("31 декабря недоступно.");
                }
            }
            else
            {
                switch (m)
                {
                    case 1: return $"{n + 1}.0{m}";
                    case 2: return $"{n % 30 + 1}.0{m}";
                    case 3: return $"{n % 28 + 1}.0{m}";
                    case 4: return $"{n % 30 + 1}.0{m}";
                    case 5: return $"{n % 31 + 1}.0{m}";
                    case 6: return $"{n % 30 + 1}.0{m}";
                    case 7: return $"{n % 31 + 1}.0{m}";
                    case 8: return $"{n % 30 + 1}.0{m}";
                    case 9: return $"{n % 31 + 1}.0{m}";
                    case 10: return $"{n % 30 + 1}.{m}";
                    case 11: return $"{n % 31 + 1}.{m}";
                    case 12: return $"{n % 30 + 1}.{m}";
                    default: throw new ArgumentException("31 декабря недоступно.");

                }
            }
        }
    }
}
