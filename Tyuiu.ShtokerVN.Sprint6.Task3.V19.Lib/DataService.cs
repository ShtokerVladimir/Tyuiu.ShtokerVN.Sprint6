using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShtokerVN.Sprint6.Task3.V19.Lib
{
    public class DataService : ISprint6Task3V19
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] temps = new int[5];
            for (int i = 0; i < 5; i++)
            {
                temps[i] = matrix[i, 4];
            }
            Array.Sort(temps);
            for (int i  = 0; i < 5; i++)
            {
                matrix[i, 4] = temps[i];
            }
            return matrix;
        }
    }
}
