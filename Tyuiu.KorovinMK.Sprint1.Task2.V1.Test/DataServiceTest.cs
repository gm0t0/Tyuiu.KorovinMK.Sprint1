using Tyuiu.KorovinMK.Sprint1.Task2.V1.Lib;
namespace Tyuiu.KorovinMK.Sprint1.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1000.0;
            var res = ds.ConvertKmToM(x);
            Assert.AreEqual(1609, res);

        }
    }
}
