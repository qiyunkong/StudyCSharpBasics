using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class MainClass
    {
        public void Greeting(string name, string language) {
            switch (language)
            {
                case "zh-cn":
                    ChineseGreeting(name);
                    break;
                case "en-us":
                    EnglishGreeting(name);
                    break;
                default:
                    break;
                    
                    
            }
        }

        public void EnglishGreeting(string name) {
            Console.WriteLine("hello" + name);
        }

        public void ChineseGreeting(string name) {
            Console.WriteLine("你好" + name);
        }
    }
}
