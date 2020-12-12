using System;

namespace ConsoleApp8
{
    class Person {

        //字段
        private  string name;
        private int age;
        private string sex;
        private static bool isMorf;

        //Name
        public string Name {
            get { return name; }
            set { name = value; }
        }

        //Age
        public int Age {
            set { age = value; }
            private get { return age; }

        }

        //性别
        public string Sex{
            set { sex = value; }
            get { return sex; }
        }       

        //静态属性不能使用非静态字段
        public static bool Morf {
            get { return isMorf; }
            set { isMorf = value; }
        }


        /* 方法重载
         * 特点： 
         * 1.方法名相同
         * 2.参数列表不同，包括：参数个数、参数类型、参数顺序
         */
        public void Print() {
            Console.WriteLine("none params");
        }

        public void Print(string name) {
            Console.WriteLine("name is {0}", name);
        }

        public void Print(int age) {
            Console.WriteLine($"age is {age}");
        }

        public void Print(int age, string name) {
            Console.WriteLine($"is age {age},name is {name}");
        }

        public void Print(string name, int age) {
            Console.WriteLine($"is name {name},age is {age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //构造函数 实例化对象
            Person p = new Person();

            p.Name = "Tony";
            p.Age = 12;
            p.Sex = "f";
        
            //静态的方法只能类调用
            Person.Morf = false;


            //调用方法 通过传入的参数列表来判断掉不同的方法
            p.Print();
            p.Print("云空");
            p.Print(20);
            p.Print(20, "云空");
            p.Print("云空", 20);


            Console.WriteLine("Hello World!");
        }
    }
}
/*
 * 
 * 个人无聊打的css 属性
 * clearfix clearfix
 * postion
 * absoltue absolute absolute absolute absolute absolute absolute 
 * relative relative relative relative relative relative relative 
 * backgorund-image
 * float
 * width: width width width width
 * height: height
 * color color
 * height height
 * header header 
 * footer footer
 * main 
 * nav 
 * list
 * item
 * first
 * second  second
 * margin margin
 * padding
 * link
 * 
 * 
 * 
 * *
 */