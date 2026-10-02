using Tyuiu.ZalyaletdinovDE.Sprint1.Task4.V0.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            int x, y;
            Console.Write("Введите значение X: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("1 / ( x ^ 2 + y ^ 2 ) = " + ds.Calculate(x, y));

        }
    }
}
