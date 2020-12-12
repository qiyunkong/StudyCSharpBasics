using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    public class Animal
    {
        
        public Animal() {
            Console.WriteLine("I am Ainmal Constructer Function");
        }
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

        public virtual void Voice()
        {
            Console.WriteLine("动物的声音");
        }
    }
}
