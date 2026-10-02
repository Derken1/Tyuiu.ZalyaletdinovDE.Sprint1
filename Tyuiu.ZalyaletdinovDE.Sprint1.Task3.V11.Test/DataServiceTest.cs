using Tyuiu.ZalyaletdinovDE.Sprint1.Task3.V11.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.TriangleArea(1, 2, 4, 6, 7, 3);
            double wai = 10.5;
            Assert.AreEqual(wai, res);
        }
    }
}
