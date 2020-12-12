using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Single
    {
        //实例构造方法
        public Single()
        {
            Console.WriteLine("实例构造函数调用了");
        }
        //静态构造方法
        static Single()
        {
            Console.WriteLine("静态构造函数调用了");
        }
        //析构构造函数
        ~Single()
        {
            Console.WriteLine("析构构造函数被调用");
        }
    }
}
