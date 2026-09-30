using Tyuiu.KorovinMK.Sprint1.Task3.V2.Lib;
namespace Tyuiu.KorovinMK.Sprint1.Task3.V2
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
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.               *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            double x;
            Console.WriteLine("Введите цену одной тетради в рублях = ");
            x = Convert.ToDouble(Console.ReadLine());
            int y;
            Console.WriteLine("Введите количество тетрадей = ");
            y = Convert.ToInt32(Console.ReadLine());
            double z;
            Console.WriteLine("Введите цену одного карандаша в рублях = ");
            z = Convert.ToDouble(Console.ReadLine());
            int r;
            Console.WriteLine("Введите цену одного карандаша = ");
            r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Результат:                                                                  *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Сумма к оплате " + ds.PurchaseAmount(x, y, z, r ));

            Console.ReadLine();

        }
    }
}

