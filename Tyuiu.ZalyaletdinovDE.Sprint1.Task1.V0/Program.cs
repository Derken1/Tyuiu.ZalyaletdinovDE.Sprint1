using Tyuiu.ZalyaletdinovDE.Sprint1.Task1.V0.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task1.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Залялетдинов Д. Э. | РППб-26-1";
            //Длинна строки 75 символов
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                         *");
            Console.WriteLine("* Задание #0                                                                               *");
            Console.WriteLine("* Вариант #4                                                                               *");
            Console.WriteLine("* Выполнил: Залялетдинов Данил Эдуардович | РППб-26-1                                      *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу, оторая запрашивает у пользователя исходные данные,                   *");
            Console.WriteLine("* вычисляет результат по формуле x / ( y - 1 ) и печатает его на экране                    *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            double x, y;
            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

        }
    }
}
