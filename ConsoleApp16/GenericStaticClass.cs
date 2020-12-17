using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    public static class GenericStaticClass<T>
    {
        static GenericStaticClass()
        {
            Console.WriteLine("调用泛型静态构造函数");
        }

        public static void Print() { }
    }
}
