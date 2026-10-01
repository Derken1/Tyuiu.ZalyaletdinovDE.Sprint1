using Tyuiu.ZalyaletdinovDE.Sprint1.Task2.V0.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.Sqr(x);
            Assert.AreEqual(4, res);
        }
    }
}
