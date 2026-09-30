using Tyuiu.KorovinMK.Sprint1.Task3.V2.Lib;
namespace Tyuiu.KorovinMK.Sprint1.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            int y = 2;
            double z = 4.0;
            int r = 2;
            double wait = 10.0;
            var res = ds.PurchaseAmount(x, y, z, r);
            Assert.AreEqual(wait, res);
        }
    }
}
