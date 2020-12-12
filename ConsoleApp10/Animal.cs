using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public class Animal
    {
        //字段
        private string name;
        private int age;

        //共有属性
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            //赋值
            set
            {
                if (value >= 0 && value <= 120)
                {
                    age = value;
                }
                else
                {
                    age = 80;
                    Console.WriteLine("Age Beyond arrange");
                }
            }
        }
    }
}
