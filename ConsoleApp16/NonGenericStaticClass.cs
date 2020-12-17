using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    public static class NonGenericStaticClass
    {
        static NonGenericStaticClass() {
            Console.WriteLine("调用非泛型静态的构造函数");
        }

        public static void Print() {}
    }
}
