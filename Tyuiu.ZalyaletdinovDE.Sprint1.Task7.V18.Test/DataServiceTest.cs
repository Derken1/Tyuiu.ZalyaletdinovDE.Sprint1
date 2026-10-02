using Tyuiu.ZalyaletdinovDE.Sprint1.Task7.V18.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4, y = 5;
            var res = ds.Calculate(x, y);
            double wait = 4.196;

            Assert.AreEqual(wait, res);
        }
    }
}
