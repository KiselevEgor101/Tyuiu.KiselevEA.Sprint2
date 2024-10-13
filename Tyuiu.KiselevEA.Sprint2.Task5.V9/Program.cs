using Tyuiu.KiselevEA.Sprint2.Task5.V9.Lib;
using System.ComponentModel.Design;

namespace Tyuiu.KiselevEA.Sprint2.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Киселев Е. А. | СМАРТб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Киселев Егор Алексеевич | СМАРТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y      *");
            Console.WriteLine("* с использованием тернарного оператора                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int Month, Day;

            Console.WriteLine("Введите номер месяца: ");
            Month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер дня: ");
            Day = Convert.ToInt32(Console.ReadLine());

            if ((Month > 12 || Day > 31) || (Month % 2 != 0 && Day == 31) || (Month == 2 && Day > 28))
            {
                Console.WriteLine("Такой даты не существует.");
            }
            else
            {
                Console.WriteLine(ds.FindDateOfNextDay(Month, Day));
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
        }
    }
}
