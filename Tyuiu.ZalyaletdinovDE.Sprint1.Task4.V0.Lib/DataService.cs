using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task4.V0.Lib
{
    public class DataService : ISprint1Task4V0
    {
        public double Calculate(double x, double y)
        {
            return 1 / (Math.Pow(x, 2)+Math.Pow(y, 2));
        }
    }
}
