using Tyuiu.ZalyaletdinovDE.Sprint1.Task7.V18.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task7.V18
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
            Console.WriteLine("* Задание #7                                                                               *");
            Console.WriteLine("* Вариант #18                                                                              *");
            Console.WriteLine("* Выполнил: Залялетдинов Данил Эдуардович | РППб-26-1                                      *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным значениям     *");
            Console.WriteLine("* данных, вводимых пользователем. Ответ округлите до 3 знаков после запятой.               *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            double x, y;
            Console.Write("Введите значение X： ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Y： ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

        }
    }
}
