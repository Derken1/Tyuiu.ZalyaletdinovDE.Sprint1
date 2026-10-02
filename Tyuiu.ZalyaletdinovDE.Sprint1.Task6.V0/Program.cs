using Tyuiu.ZalyaletdinovDE.Sprint1.Task6.V0.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine(ds.WorkWithText(str));

        }
    }
}
