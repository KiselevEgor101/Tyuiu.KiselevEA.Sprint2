using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KiselevEA.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int k, int m)
        {
            string rank;
            string suit;

            // Определяем достоинство карты
            switch (k)
            {
                case 6: rank = "Шестёрка"; break;
                case 7: rank = "Семёрка"; break;
                case 8: rank = "Восьмёрка"; break;
                case 9: rank = "Девятка"; break;
                case 10: rank = "Десятка"; break;
                case 11: rank = "Валет"; break;
                case 12: rank = "Дама"; break;
                case 13: rank = "Король"; break;
                case 14: rank = "Туз"; break;
                default: throw new ArgumentException("Такой карты нет!");
            }

            // Определяем масть карты
            switch (m)
            {
                case 1: suit = "пики"; break;
                case 2: suit = "трефы"; break;
                case 3: suit = "бубны"; break;
                case 4: suit = "червы"; break;
                default: throw new ArgumentException("Такой масти нет!");
            }

            // Формируем полное название карты
            return $"{rank} {suit}";
        }
    }
}
