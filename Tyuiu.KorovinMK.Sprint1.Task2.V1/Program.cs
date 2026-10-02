using Tyuiu.KorovinMK.Sprint1.Task2.V1.Lib;
namespace Tyuiu.KorovinMK.Sprint1.Task2.V1
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
            Console.WriteLine("* Задание #2                                                                *");
            Console.WriteLine("* Вариант #1                                                               *");
            Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу на C# которая переводит километры в мили               *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* 1 км = 1,609 м                                                           *");

            double x;
            Console.WriteLine("Введите значение X км = ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Результат:                                                                  *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine(" X км = " + ds.ConvertKmToM(x) + " миль ");

            Console.ReadLine();

        }
    }
}

