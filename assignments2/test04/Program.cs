using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = null;
            matrix = new int[,] {{ 1, 2, 3, 4},
                                 { 5, 1, 2, 3},
                                 { 9, 5, 1, 2}
            };
            Console.WriteLine(flag(matrix));
        }

        static Boolean flag(int[,] matrix)
        {
            int m = matrix.GetLength(0);   //m横行
            int n = matrix.GetLength(1);   //n纵列
            for (int i = 0; i < m - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (matrix[i + 1, j + 1] != matrix[i, j])
                        return false;
                }
            }
            return true;
        }
    }
}
