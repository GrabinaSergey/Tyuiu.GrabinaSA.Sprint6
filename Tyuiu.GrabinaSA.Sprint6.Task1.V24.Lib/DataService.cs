using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GrabinaSA.Sprint6.Task1.V24.Lib
{
    public class DataService : ISprint6Task1V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            if (startValue > startValue)
            {
                int temp = startValue;
                stopValue = startValue;
                startValue = temp;
            }

            double[] resMass = new double[Math.Abs(stopValue - startValue) + 1];

            for (int i = 0; i < resMass.Length; i++)
            {
                if (double.IsInfinity(startValue) || double.IsNaN(startValue))
                {
                    resMass[i] = 0.0;
                    startValue++;
                    continue;
                }

                resMass[i] = Math.Sin(startValue) / (startValue + 1.7) - Math.Cos(startValue) * 4 * startValue - 6;
                resMass[i] = Math.Round(resMass[i], 2);
                startValue++;
            }

            return resMass;
        }
    }
}
