using System;

namespace ConsoleApp11
{
    public class Horse : Animal { }
    public class Sheep : Animal { }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = 130;
            Console.WriteLine("age is {0}", p.Age);

            Horse horse = new Horse();
            horse.Age = 2;
            Sheep sheep = new Sheep();
            sheep.Age = 120;
            Console.WriteLine("马的年龄为{0}", horse.Age);
            Console.WriteLine("牛的年龄为{0}", sheep.Age);

            Console.WriteLine("Hello World!");
        }
    }
}
/*  
 *  C#中的面向对象编程
 *  C#是面向对象的语言，所有面向对象的语言都具有三个基本的特征，它们是:
 *  封装:把客观事物封装成类，并将类内部实现隐藏，以保证数据的完整性。
 *  继承:通过继承可以复用父类的代码。
 *  多态:允许将子对象赋值给父对象的一种能力
 *  C#中的面向对象编程指的是运用这三个基本的特征来编写程序。下面详细的介绍一下。
 *  5.1封装
 *      封装指的是把类的内部实现隐藏起来，不让对象直接对其进行操作。C#提供了属性机制对内部的状态进行操作。
 *  在C#中，封装可以通过public, protected, private,internal来体现
 *      为什么使用封装，因为有的时候，我们把内部的数据定义为public之后，
 *  外部对象可以进行任意的操作，很可能导致不符合逻辑
 *      面向对象的封装特性，是一种保护状态数据完整性的方法，在面向对象编程中，
 *  应更多的定义私有字段，并且使用属性机制来对私有字段进行访问。下面代码演示了封装的具体操作。
 *  
 *  
 *  
 *  
 *  
 *  
 *  
 * 
 * **/
