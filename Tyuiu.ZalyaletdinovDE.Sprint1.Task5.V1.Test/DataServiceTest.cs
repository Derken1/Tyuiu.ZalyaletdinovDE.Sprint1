using Tyuiu.ZalyaletdinovDE.Sprint1.Task5.V1.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 2, y1 = 5, x2 = 5, y2 = 9;
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            int wait = 5;

            Assert.AreEqual(wait, res);
        }
    }
}
