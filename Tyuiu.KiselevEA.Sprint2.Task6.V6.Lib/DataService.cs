using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KiselevEA.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int k, int m)
        {
            if (m < 6 || m > 14)
            {
                throw new ArgumentException("Значение достоинства карты должно быть от 6 до 14!");
            }

            if (k < 1 || k > 4)
            {
                throw new ArgumentException("Значение масти карты должно быть от 1 до 4!");
            }

            string rank;
            string suit;

            // Определяем достоинство карты
            switch (m)
            {
                case 6: rank = "Шестёрка"; break;
                case 7: rank = "Семёрка"; break;
                case 8: rank = "Восьмёрка"; break;
                case 9: rank = "Девятка"; break;
                case 10: rank = "Десятка"; break;
                case 11: rank = "Валет"; break;
                case 12: rank = "дама"; break;
                case 13: rank = "Король"; break;
                case 14: rank = "Туз"; break;
                default: throw new ArgumentException("Такой карты нет!");
            }

            // Определяем масть карты
            switch (k)
            {
                case 1: suit = "пик"; break;
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
