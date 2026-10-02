using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KorovinMK.Sprint1.Task2.V1.Lib
{
    public class DataService : ISprint1Task2V1
    {
        public int ConvertKmToM(int value)
        {
            var res = value * 1.609;
            return (int) Math.Round(res, 3);
        }

        double ISprint1Task2V1.ConvertKmToM(int value)
        {
            var res = value * 1.609;
            return (int)Math.Round(res, 3);
        }
    }
}
