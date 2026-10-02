using Tyuiu.ZalyaletdinovDE.Sprint1.Task3.V0.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task3.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2, y = 3;
            double wait = 6;
            var res = ds.Calculate(2, 3);
            Assert.AreEqual(wait, res);
        }
    }
}
