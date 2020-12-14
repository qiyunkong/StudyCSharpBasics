using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    class Friend
    {
        //公有字段
        public string Name;
        //构造函数
        public Friend(string name)
        {
            Name = name;
        }

        //事件处理函数 接受事件发布者发布的消息
        public void SendMessage(string msg)
        {
            Console.WriteLine($"msg:{msg}");
            //处理事件

            Console.WriteLine(this.Name + "收到了，已上号");
        }

        public void SendMessage(object s, EventArgs e) {
            Console.WriteLine($"s的类型为{s}");
            Console.WriteLine($"强转获取:{((Bridegroom)s).Message}");
            Console.WriteLine($"e的类型为{e}");
            Console.WriteLine(this.Name + "收到了，已上号");
        }


        public void SendMessage(object s, MarryEventArgs e)
        {
            Console.WriteLine($"s的类型为{s}");
            Console.WriteLine($"强转获取:{((Bridegroom)s).Message}");
            Console.WriteLine($"e.message为{e.message}");
            Console.WriteLine(this.Name + "收到了，已上号");
        }
    }
}
