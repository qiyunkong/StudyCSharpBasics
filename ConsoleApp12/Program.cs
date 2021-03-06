﻿using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * 调用接口中的方法
             *   前面介绍了如何继承一个接口并且实现其中的方法，
             *   接下来看如何去调用接口中的方法，具体调用代码如下: 
             * **/
            Person p1 = new Person();
            Person p2 = new Person();
            p1.Age = 20;
            p2.Age = 30;

            if (p1.CompareTo(p2) > 0)
            {
                Console.WriteLine("P1 greater than p2!");
            }
            else if (p1.CompareTo(p2) < 0)
            {
                Console.WriteLine("p1 less than p2!");
            }
            else {
                Console.WriteLine("p1 equal to p2!");
            }
          


            Greet greet = new Greet();

            ((IChineseGreeting)greet).sayHello();

            IChineseGreeting chinese = greet;
            chinese.sayHello();

            IAmericanGreeting american = greet;
            american.sayHello();

            Console.ReadKey();

        }
    }
}
/*
 * 什么是接口
 * 接口可以理解为对一组方法声明进行的统一命名，
 * 但是这些方法没有提供任何实现。也就是说，把一组方法声明在一个接口中，
 * 然后继承于该接口的类都需要实现这些方法。
 * 通过接口，你可以对方法进行统一管理，避免了在每一种类型中重复定义这些方法。
 * 
 * 显示接口
 *  在上述的代码之中，使用了隐式的接口实现，即没有指定实现哪个接口的方法。
 *  对应的就有显式的接口实现方式，它指的是在实现过程中，明确指出实现哪一个接口的哪一个方法。
 *   当多个接口包含相同方法名称，相同返回类型和相同参数时，如果一个类同时实现了这些接口，隐式的接口就会出现命名冲突的问题，
 *   
  接口经常与抽象类一起使用，共同服务于面向对象的编程，简单分析一下区别:
    1:抽象类使用abstract关键字进行定义，接口使用interface进行定义，它们都不能实例化
    2:抽象类可以包含虚方法、非抽象方法和静态成员;但接口不能包含虚方法和任何静态成员，并且接口中只能定义方法，不能有具体实现。
    3:抽象类不能实现多继承，接口支持多继承。
    4:抽象类本质是一个类;接口只是代表实现类具有接口声明的方法，是一种CAN——DO关系。
 *  
 * 
 * **/

