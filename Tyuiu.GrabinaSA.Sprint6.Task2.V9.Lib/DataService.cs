using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GrabinaSA.Sprint6.Task2.V9.Lib
{
    public class DataService : ISprint6Task2V9
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] vallueArray;
            int len = (stopValue - startValue) + 1;
            vallueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (3 * x - 1.5 != 0)
                {
                    vallueArray[count] = Math.Round((3 * x - 1.5) / (Math.Sin(x) - 3 + x) + 2, 2);
                    count++;
                }
                else
                {
                    vallueArray[count] = 0;
                    count++;
                }
            }
            return vallueArray;
        }
    }
}
