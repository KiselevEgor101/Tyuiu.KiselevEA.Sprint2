using Tyuiu.KiselevEA.Sprint2.Task6.V6.Lib;
namespace Tyuiu.KiselevEA.Sprint2.Task6.V6
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
            Console.WriteLine("* Задание #6                                                              *");
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

            int k, m;

            Console.WriteLine("Введите номер карты(6-14): ");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер масти(1-4): ");
            m = Convert.ToInt32(Console.ReadLine());

            if((k < 6) && (k > 14))
            {
                Console.WriteLine("Такой карты нет.");
            }
            else
            {
                Console.WriteLine(ds.FindCardNameAndValue(m, k));
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
        }
    }
}
