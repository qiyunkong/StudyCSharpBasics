using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp16
{
    //where 是约束 T必须和IComparable是继承关系
    class CompareClass<T> where T:IComparable
    {
        public static T CompareValue(T Value1,T Value2) {
            if (Value1.CompareTo(Value2) > 0)
            {
                return Value1;
            }
            else {
                return Value2;
            }
        }


        /*测试使用泛型时执行时间*/
        public static void testGenericList() {
            Stopwatch stopwatch = new Stopwatch();
            List<int> gelist = new List<int>();

            stopwatch.Start();
            for (int i = 0; i < 100000000; i++) {
                gelist.Add(i);
            }
            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;
            //String.Format 格式模板
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds/10);

            Console.WriteLine("使用泛型运行时间是" + elapsedTime);
             
        }

       
        /*不使用的时间*/
        public static void testGenericArrayList()
        {
            Stopwatch stopwatch = new Stopwatch();
            ArrayList gelist = new ArrayList();

            stopwatch.Start();
            for (int i = 0; i < 100000000; i++)
            {
                gelist.Add(i);
            }
            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;
            //String.Format 格式模板
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds/10);

            Console.WriteLine("没有使用泛型运行时间是" + elapsedTime);

        }

    }
}
/**
 * 泛型的好处
 *  1.泛型能够实现代码复用
 *  2.泛型能够减少装箱操作，避免性能损失
 *  3.减少处理器的负担，加快运行速度
 * 
 * 
 * **/