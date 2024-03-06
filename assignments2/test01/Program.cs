using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入整数：");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("它的所有素因子为：");
            for (int i = 2; i <= num;)
            {
                if (num % i == 0)    //判断i是否为num因子
                {
                    num /= i;
                    Console.WriteLine(i);
                    i = 2;  //重新返回2开始检验
                }
                else
                {
                    i++;  //i增加一定为依次的最小素数
                }
            }
        }
        //static Boolean shusu(int n)
        //{
        //    for (int j = 2; j <= Math.Sqrt(n); j++)
        //    {
        //        if (n % j == 0)
        //            return false;
        //    }
        //    return true;
        //}

        //static void allput(int num)
        //{
        //    int i;
        //    for (i = 2; i < num;  i++)
        //    {
        //        if (shusu(i) && (num%i==0))
        //        {
        //            Console.WriteLine(i);
        //            break;
        //        }
        //    }
        //    allput(num / i);
        //}
    }
}
