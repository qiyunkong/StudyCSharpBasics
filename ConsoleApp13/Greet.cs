using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class Greet
    {
        public delegate void GreetDelegate(string name);
        public delegate void DelegateChain();

        public static void Greeting(string name, GreetDelegate gd) {
            gd(name);
        }



        public void ChineseGreeting(string name) {
            Console.WriteLine("你好" + name);
        }

        public void EnglandGreeting(string name) {
            Console.WriteLine("Hello" + name);
        }


        public void staticMethod()
        {
            Console.WriteLine("ststic method");
        }

        public void method()
        {
            Console.WriteLine("instance method");
        }
    }
}
