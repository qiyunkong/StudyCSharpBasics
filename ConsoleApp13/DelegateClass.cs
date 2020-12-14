using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class DelegateClass
    {
        /*定义委托*/
        public delegate void MyDelegate(int para1, int para2);


        public void Add(int a, int b)
        {
            Console.WriteLine("a+b = {0}", a + b);
        }

        public static void MyDelegateMethod(MyDelegate myDelegate)
        {

            /*调用委托*/
            myDelegate(23, 12);

        }
    }
}
