using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    public class Greet : IAmericanGreeting, IChineseGreeting
    {
        void IChineseGreeting.sayHello() {
            Console.WriteLine("你好");
        }

        void IAmericanGreeting.sayHello(){
            Console.WriteLine("Hello");
        }
    }
}
