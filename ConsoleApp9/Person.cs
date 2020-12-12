using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Person
    {
        /*字段*/
        public int age;
        public string name;

        //最简单的个单例模式
        public static Person person_static = new Person();

        public static Person person;

        public static int id;

        /*属性*/
        public int Age { set; get; }

        /*
         * 静态构造函数
         * 特点：
         * 1.没有访问修饰符
         * 2.没有返回值类型，也没有返回值
         * 3.无参
         * 4.方法名与类名相同
         * 5.只能调用一次
         * 6.程序员无法直接控制静态构造函数的调用时机(初始化之前触发)
         * 7.不能够显示的
         */

        static Person()
        {
            Console.WriteLine("static  Constructor  Function");
            //this不能访问静态字段    
            id = 10001;
        }

        /*
         * 实例构造函数 
         * 特点: 
         * 1.可以访问修饰符进行修饰 
         * 2.无返回值 
         * 3.无数据类型
         * 4.方法名与类名相同
         * 5.可以有参数
         * 6.可以实现方法重载
         * 7.如果没有显示的定义构造函数，默认会产生一个无参的构造函数
         * 8.如果显示的定义了构造函数，将会把系统默认的构造函数覆盖掉
         */
        public Person()
        {
            this.age = 20;
            this.name = "云空";
        }

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }



        //静态方法 单例模式
        public static Person getInstance()
        {
            if (person == null) //判断对象是否第一次
            {
                person = new Person(); //是第一次就构造函数实例化
            }
            return person;
        }

    }
}
