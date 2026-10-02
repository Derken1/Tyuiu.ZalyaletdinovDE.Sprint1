using Tyuiu.ZalyaletdinovDE.Sprint1.Task5.V0.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            double x;
            Console.Write("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            int res = Convert.ToInt32(ds.Calculate(x));

            Console.WriteLine("x ^ 2 / sqrt(x) = " + res);

        }
    }
}
