using Tyuiu.ZalyaletdinovDE.Sprint1.Task4.V10.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 2;
            double wait = 0.706;
            var res = ds.Calculate(a);
            Assert.AreEqual(wait, res);

        }
    }
}
