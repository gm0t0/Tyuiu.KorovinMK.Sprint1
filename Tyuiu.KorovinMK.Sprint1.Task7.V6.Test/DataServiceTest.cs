using Tyuiu.KorovinMK.Sprint1.Task7.V6.Lib;
namespace Tyuiu.KorovinMK.Sprint1.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double z = -22;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}
