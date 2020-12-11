using System;

namespace ConsoleApp8
{
    class Person {
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
    }

    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            p.Name = "Tony";
            p.Age = 12;
            
            p.Sex = "f";
        
            Person.Morf = false;
            Console.WriteLine("Hello World!");
        }
    }
}
/*
 * clearfix
 * postion
 * absoltue absolute 
 * relative relative
 * backgorund-image
 * float
 * width:
 * height:
 * color
 * height
 * header
 * footer
 * mian
 * nav
 * list
 * item
 * first
 * second
 * margin
 * padding
 * link
 * 
 * 
 * 
 * *
 */