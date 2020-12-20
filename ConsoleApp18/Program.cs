using System;

namespace ConsoleApp18
{


    class Program
    {
        //定义委托
        public delegate void Mydelegate<DelegateT>(DelegateT num);

        //定义静态方法
        public static void Method(int num) {
            Console.WriteLine("Method method method,num:" + num);
        }


        public static void Method2(Mydelegate<string> d) {
            d("123456");
        }

        public static void Print(string str) {
            Console.WriteLine("str:" + str);
        }

        static void Main(string[] args)
        {

            Mydelegate<int> d;
            d = new Mydelegate<int>(Program.Method);
            d(123456);

            Program.Method2(Program.Print);

            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
