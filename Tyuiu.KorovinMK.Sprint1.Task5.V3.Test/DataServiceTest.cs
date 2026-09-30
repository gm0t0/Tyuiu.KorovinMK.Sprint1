using Tyuiu.KorovinMK.Sprint1.Task5.V3.Lib;
namespace Tyuiu.KorovinMK.Sprint1.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 1234567;
            int h = ds.Calculate(k);
            
            Assert.AreEqual(5, h);

        }
    }
}
