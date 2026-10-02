using Tyuiu.ZalyaletdinovDE.Sprint1.Task6.V11.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task6.V11
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
            Console.WriteLine("* Задание #5                                                                               *");
            Console.WriteLine("* Вариант #1                                                                              *");
            Console.WriteLine("* Выполнил: Залялетдинов Данил Эдуардович | РППб-26-1                                      *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что первая                     *");
            Console.WriteLine("* буква строки входит в нее еще раз.                                                       *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.Write("Введите текст： ");
            string str = Console.ReadLine();

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine(ds.CheckeFirstLetterRepetition(str));

        }
    }
}
