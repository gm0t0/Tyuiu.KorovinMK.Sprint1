using Tyuiu.KorovinMK.Sprint1.Task6.V8.Lib;
namespace Tyuiu.KorovinMK.Sprint1.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Привет молодеж";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd(strTest);
            string wait = "риветП олодежм";
            Assert.AreEqual(wait, res);


        }
    }
}
