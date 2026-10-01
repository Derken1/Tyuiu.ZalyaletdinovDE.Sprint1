using Tyuiu.ZalyaletdinovDE.Sprint1.Task1.V27.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(3, 3);
            Assert.AreEqual(3, res);
        }
    }
}
