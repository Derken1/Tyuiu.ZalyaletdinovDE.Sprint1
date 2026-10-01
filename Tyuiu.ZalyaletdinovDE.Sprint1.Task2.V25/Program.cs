using Tyuiu.ZalyaletdinovDE.Sprint1.Task2.V25.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task2.V25
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
            Console.WriteLine("* Задание #2                                                                               *");
            Console.WriteLine("* Вариант #25                                                                              *");
            Console.WriteLine("* Выполнил: Залялетдинов Данил Эдуардович | РППб-26-1                                      *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, выполняет        *");
            Console.WriteLine("* указанные расчёты и печатает результат на экране.                                        *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            int x;

            Console.WriteLine("Введите число радиан: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("В градусах - " + ds.ConvertRadsToDegrees(x));

        }
    }
}
