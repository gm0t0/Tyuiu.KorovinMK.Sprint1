using Tyuiu.KorovinMK.Sprint1.Task6.V8.Lib;
namespace Tyuiu.KorovinMK.Sprint1.Task6.V8
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
            Console.WriteLine("* Задание #6                                                                *");
            Console.WriteLine("* Вариант #8                                                                *");
            Console.WriteLine("* Выполнил: Коровин Матвей Константинович| ИСТНб-26-1                       *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("*Написать программу, которая решает следующую задачу:                       *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать все слова,      *");
            Console.WriteLine("  перенеся их первую букву в конец.                                          ");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            string result = ds.MoveLetterToEnd(text);




            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Результат:                                                                  *");
            Console.WriteLine("*****************************************************************************");


            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}


