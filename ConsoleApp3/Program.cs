using System;

namespace ConsoleApp3
{
    //枚举
    enum Gender {
        Female,
        Male = 5,
        Node,
    }
    class Program
    {

        static void Main(string[] args)
        {
            //枚举默认 从0开始标号
            Console.WriteLine((int)Gender.Female);
            Console.WriteLine((int)Gender.Male);
            Console.WriteLine((int)Gender.Node);
            Console.ReadKey();            
        }
    }
}
