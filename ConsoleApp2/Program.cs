using System;

namespace ConsoleApp2
{
    class Program
    {
        //类型转换
        static void Main(string[] args)
        {
            //使用强制类型转换
            int num = 100;
            float f = (float)num;
            Console.WriteLine("f is {0}",f);


            //使用System.Convert类中的静态方法
            num = 110;
            string str = System.Convert.ToString(num);
            Console.WriteLine(str);


            //使用.net框架提供Parse方法
            str = "200";
            f = float.Parse(str);
            Console.WriteLine(str);



            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
