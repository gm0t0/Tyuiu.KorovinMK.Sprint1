using Tyuiu.KorovinMK.Sprint1.Task7.V6.Lib;
namespace Tyuiu.KorovinMK.Sprint1.Task7.V6
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
            Console.WriteLine("* Задание #7                                                                *");
            Console.WriteLine("* Вариант #6                                                                *");
            Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение            *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                     *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("                 x                                                          *");
            Console.WriteLine("(         1    )       2                                                    *");
            Console.WriteLine("( 1 + ---------)  - 12x * y                                                 *");
            Console.WriteLine("(        x^2  )                                                             *");
            Console.WriteLine("*****************************************************************************");
            double x, y;


            Console.Write("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());




            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Результат:                                                                  *");
            Console.WriteLine("*****************************************************************************");


            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();

        }
    }
}


