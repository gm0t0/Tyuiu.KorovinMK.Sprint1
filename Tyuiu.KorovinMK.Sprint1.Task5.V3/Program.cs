using Tyuiu.KorovinMK.Sprint1.Task5.V3.Lib;
namespace Tyuiu.KorovinMK.Sprint1.Task5.V3
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
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #3                                                                *");
            Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("*Написать программу, которая решает следующую задачу:                       *");
            Console.WriteLine("*   Присвоить целой переменной h третью от конца цифру в записи             *");
            Console.WriteLine(" положительного целого числа k (например, если k=130985, то h=9).            ");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            int k;
            Console.WriteLine("Введите значение k =");
            k = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Результат:                                                                  *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Ответ :" + ds.Calculate(k));


            Console.ReadLine();

        }
    }
}

