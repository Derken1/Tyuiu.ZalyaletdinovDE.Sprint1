using Tyuiu.ZalyaletdinovDE.Sprint1.Task6.V11.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string str = "dead";
            var res = ds.CheckeFirstLetterRepetition(str);
            Assert.IsTrue(res);
        }
    }
}
