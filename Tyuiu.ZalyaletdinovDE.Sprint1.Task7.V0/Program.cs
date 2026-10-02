using Tyuiu.ZalyaletdinovDE.Sprint1.Task7.V0.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            double x, y, z;
            Console.Write("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Z: ");
            z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine(ds.Calculate(x, y, z));

        }
    }
}
