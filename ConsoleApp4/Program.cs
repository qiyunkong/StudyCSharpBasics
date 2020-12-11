using System;

namespace ConsoleApp4
{
    //声明结构体
    public struct StructDemo {
        public float x;
        public float y;

        public StructDemo(float xPos, float yPos)
        {
            x = xPos;
            y = yPos;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //使用结构体 必须进行初始化不然会报错
            StructDemo s1;
            s1.x = 10f;
            s1.y = 20f;
            Console.WriteLine(s1.x + " " + s1.y);


            //new 使用结构体
            StructDemo s2 = new StructDemo();
            Console.WriteLine(s2.x + " " + s2.y);

            //new 使用机构体
            StructDemo s3 = new StructDemo(10f,10f);
            Console.WriteLine(s3.x + " " + s3.y);


            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
/*
 
     struct 结构体
        结构体中的变量不能初始化
        new 出的结构体实例是访问中的变量是不会变错的，反之会报错
        
     
     
     
     
     */