using Tyuiu.ZalyaletdinovDE.Sprint1.Task3.V0.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task3.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            double a = 12, b = 17;

            Console.WriteLine("Сторона A прямоугольника: " + a);
            Console.WriteLine("Сторона B прямоугольника: " + b);

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Площадь прямоугольника = " + ds.Calculate(a, b));

        }
    }
}
