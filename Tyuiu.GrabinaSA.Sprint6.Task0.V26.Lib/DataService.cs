using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GrabinaSA.Sprint6.Task0.V26.Lib
{
    public class DataService : ISprint6Task0V26
    {
        public double Calculate(int x)
        {
            double res = (Math.Pow(x, 2) + 1) / (3 * x + 4);
            return Math.Round(res, 3);
        }
    }
}
