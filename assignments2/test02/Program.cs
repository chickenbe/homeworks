using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入整数数组个数：");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入数组元素：");
            int[] a = new int[n];
            for (int i=0;i<n;i++)
            {
                a[i]= Convert.ToInt32(Console.ReadLine());
            }
            int maxn = a[0], minn = a[0];
            int num=0;
            for (int i=0;i<n;i++)
            {
                maxn=maxn < a[i] ? a[i]: maxn;
                minn=minn > a[i] ? a[i]: minn;
                num += a[i];
            }
            double average=Convert.ToDouble(num/n);
            Console.WriteLine("最大值为：" + maxn);
            Console.WriteLine("最小值为：" + minn);
            Console.WriteLine("平均数为：" + average);
            Console.WriteLine("所有数组元素的和为：" + num);
        }
    }
}
