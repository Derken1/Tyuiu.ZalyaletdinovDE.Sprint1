using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZalyaletdinovDE.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            return value[1..].Contains(value[0]);
        }
    }
}
