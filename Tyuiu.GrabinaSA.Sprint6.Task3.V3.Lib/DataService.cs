using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GrabinaSA.Sprint6.Task3.V3.Lib
{
    public class DataService : ISprint6Task3V3
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int[] nums = new int[5];
            int d = 0;
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < columns; j++)
                {
                    if (j == 1)
                    {
                        nums[d] = matrix[i, j];
                        d++;
                    }
                }

            }

            Array.Sort(nums);
            int v = 0;
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < columns; j++)
                {
                    if (j == 1)
                    {
                        matrix[i, j] = nums[v];
                        v++;
                    }
                }

            }


            return matrix;
        }
    }
}

       