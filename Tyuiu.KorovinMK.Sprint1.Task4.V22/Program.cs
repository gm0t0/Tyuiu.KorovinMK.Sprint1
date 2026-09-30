using Tyuiu.KorovinMK.Sprint1.Task4.V22.Lib;
namespace Tyuiu.KorovinMK.Sprint1.Task4.V22
{
    class Program
    {

        public static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнлил: Коровин М. К| ИСНТб-26-1";

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                 *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
            Console.WriteLine("* Задание #3                                                                *");
            Console.WriteLine("* Вариант #2                                                                *");
            Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,   *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                  *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            double x, y;
            Console.WriteLine("Введите значение x = ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y = ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Результат:                                                                  *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Ответ :" + ds.Calculate(x, y));
            

            Console.ReadLine();

        }
    }
}

