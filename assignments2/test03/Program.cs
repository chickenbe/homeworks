using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[150];
            a[0] = a[1] = 1;
            a[2] = 0;
            int k = 2, count = 0;    //k为去除的倍数，count为当前计数次数
            while (count < 101)
            {
                for (int i = 1; i < 101; i++)  
                {
                    if (i % k == 0 && i != k)
                        a[i] = 1;    //a[i]不是素数
                }

                for (int i = 1; i < 101; i++)
                {
                    if (i > k && a[i] == 0)
                    {
                        k = i;   //替换新的k
                        break;
                    }
                }
                count++;
            }

            for (int i = 1; i < 101; i++)
                if (a[i] == 0)   //此时a[i]即为素数
                    Console.WriteLine(i);
        }
    }
}
    
