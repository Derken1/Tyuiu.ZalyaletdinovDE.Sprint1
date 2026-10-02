using Tyuiu.ZalyaletdinovDE.Sprint1.Task7.V0.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task7.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3, y = 2, z = 1;
            double wait = 0.75;
            var res = ds.Calculate(x, y, z);
            Assert.AreEqual(wait, res);
        }
    }
}
