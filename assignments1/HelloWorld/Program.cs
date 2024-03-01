using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s,t,x;
            Double a, b;
            Console.WriteLine("请输入第一个数：");
            s = Console.ReadLine();
            a=Double.Parse(s);
            Console.WriteLine("请输入运算符：");
            x = Console.ReadLine();
            Console.WriteLine("请输入第二个数：");
            t = Console.ReadLine();
            b=Double.Parse(t);
            Console.WriteLine("计算结果为：");
            switch (x) 
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
                case "%":
                    Console.WriteLine(a % b);
                    break;
                default:
                    Console.WriteLine(0);
                    break;
            }
        }
    }
}
