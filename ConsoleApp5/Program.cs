using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {


            //1.声明 一个长度为5并名字为a的数组
            int[] a = new int[5];
            a[0] = 1;
            a[1] = 2;
            Console.WriteLine(a[0] + " " + a[3]);

            //2.声明一个数组
            int[] numArray = new int[] { 1, 2, 3, 4, 5 };
            string str = "";
            for (int i = 0; i < numArray.Length; i++)
            {
                str += numArray[i];
             
            }
            Console.WriteLine("我是for循环="+str);

            //3.声明一个数组
            int[] numArray2 = { 1, 2, 3, 4, 5, };
            str = "";
            foreach (var item in numArray2)
            {
                str += item;
            }
            Console.WriteLine("我是foreach循环="+str);
            Console.ReadKey();
        }
    }
}
