using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPrint
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>    //泛型
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            head = null;
            tail = null;
        }

        public Node<T> Head
        {
            get 
            {
                return head;
            }
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = n;
                tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            for (Node<T> i = head; i != null; i = i.Next)
            {
                action(i.Data);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            GenericList<int> list = new GenericList<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rd.Next() % 100);   //随机数据测试
            }
            int sum = 0;
            int maxn = Int32.MinValue;
            int minn = Int32.MaxValue;

            list.ForEach(n => Console.WriteLine(n));
            list.ForEach(n => { maxn = maxn > n ? maxn : n; });
            list.ForEach(n => { minn = minn < n ? minn : n; });
            list.ForEach(n => sum += n);

            Console.WriteLine("最大值是：" + maxn);
            Console.WriteLine("最小值是：" + minn);
            Console.WriteLine("求和是：" + sum);

        }

    }
}