using System;

namespace ConsoleApp19
{
    /*
     * 泛型方法重载：
     * 调用时，系统会优先匹配已经指定好
     * 参数数据类型的方法，如果匹配成功
     * 则执行方法中的程序，否者，继续匹配
     * 其他没有事先指定参数类型的方法，匹配
     * 成功，则执行方法中的程序
     * **/
    public class Node<T, V> {

        
        public T Nul(T a, V b) {
            Console.WriteLine("First method Value:" + a );
            return a;
        }

        public T Nul(V a, T b) {
            Console.WriteLine("Second method Value:" + b);
            return b;
        }

        public int Nul(int a, int b) {
            Console.WriteLine("Third method Value:" + (a + b));
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node<string, int> d = new Node<string, int>();
            string result = d.Nul(12,"123");

            Console.WriteLine("result=" + result);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
