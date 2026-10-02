using Tyuiu.ZalyaletdinovDE.Sprint1.Task4.V0.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task4.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 3, y = 4;

            double wait = 0.04;

            var res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}
