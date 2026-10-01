using Tyuiu.ZalyaletdinovDE.Sprint1.Task2.V25.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 3;
            var res = ds.ConvertRadsToDegrees(x);
            Assert.AreEqual(171.887, res);
        }
    }
}
