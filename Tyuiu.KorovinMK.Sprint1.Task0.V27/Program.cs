using Tyuiu.KorovinMK.Sprint1.Task0.V27.Lib;
namespace Tyuiu.KorovinMK.Sprint1.Task0.V27
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
            Console.WriteLine("* Задание #0                                                                *");
            Console.WriteLine("* Вариант #27                                                               *");
            Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу на C# которая решает выражение: 5 * 2 + 4 * 3          *");
            Console.WriteLine("* и напечатает результат на экране.                                         *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* 5 * 2 + 4 * 3                                                             *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Результат:                                                                  *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine(ds.Calculate());
            Console.ReadLine();

        }
    }
}
