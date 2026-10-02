using Tyuiu.ZalyaletdinovDE.Sprint1.Task3.V11.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task3.V11
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
            Console.WriteLine("* Задание #3                                                                               *");
            Console.WriteLine("* Вариант #11                                                                              *");
            Console.WriteLine("* Выполнил: Залялетдинов Данил Эдуардович | РППб-26-1                                      *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данныe,                  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                              *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            double x1, x2, x3, y1, y2, y3;
            Console.Write("x1 -> ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y1 -> ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("x2 -> ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y2 -> ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("x3 -> ");
            x3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y3 -> ");
            y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Площадь треугольника: " + ds.TriangleArea(x1, y1, x2, y2, x3, y3) + " кв.см");

        }
    }
}
