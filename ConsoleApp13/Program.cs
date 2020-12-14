using System;

namespace ConsoleApp13
{
   
    class Program
    {

        static void Main(string[] args)
        {
            /*声明委托*/
            DelegateClass.MyDelegate  d;

            /*实例化委托*/
            d = new DelegateClass.MyDelegate(new DelegateClass().Add);

            /*将委托变量作为参数进行传递*/
            DelegateClass.MyDelegateMethod(d); //可以传递委托的实例，也可以直接传递方法
          
            Console.WriteLine("Hello World!");

            Greet greet = new Greet();

            //第一种传递方式
            Greet.Greeting("yunkong", new Greet.GreetDelegate(greet.EnglandGreeting));

            //第二种传递方式
            Greet.Greeting("张三", greet.ChineseGreeting);
            Greet.Greeting("lishi", greet.EnglandGreeting);


            //委托链
            Greet.DelegateChain d1 = new Greet.DelegateChain(greet.method);
            Greet.DelegateChain d2 = new Greet.DelegateChain(greet.staticMethod);
            Greet.DelegateChain chain = null;

            /*委托*/
            chain += d1;
            chain += d2;
            chain();
            /*取消委托*/
            chain -= d2;
            chain();

            Console.ReadKey();
        }

 


    
    }
}


/**
 * 委托是C#重要的特性之一，C#后面的所有特性都是建立在委托的基础之上，下面我们开始学习委托的知识。
7.1 什么是委托
    法庭上律师为当事人进行辩护，他真正执行的是当事人的陈词，
  律师就是一个委托对象，当事人则委托律师进行辩护。
    C#的委托可以理解函数的一个包装，
  它使得C#中的函数可以作为参数进行传递，这在作用上相当于C++中的函数指针。
委托的定义和方法的定义类似，只是在定义的前面多了一个delegate关键字。
    下面就是一个委托的例子:
public delegate void MyDelegate(int para1, string para2)
委托能包装的方法也是有一定限制的，例如能被前面的委托类型MyDelegate包装的方法需要满足以下几个条件:

1:方法的返回类型必须为void;
2:方法必须有两个参数，并且第一个参数应为int类型，第二个参数为string类型。
归纳起来，可以被委托包装的方法必须满足以下规则:
1:方法的签名必须与委托一致，方法签名包括参数的个数，类型和顺序。
2:方法的返回类型要和委托一致。
与上面方法对应的函数可以是下面的这种:public void MyMethod (int a,string b){}

    7.3 为什么要引入委托
我们通过下面的例子来看一下为什么使用委托，有什么好处?首先我们不使用委托来实现下面的代码:


    前面介绍的都是委托封装一个方法的情况，即理解为一个律师只为一个当事人辩护。但是律师为多个当事人辩护时存在的。C#中的委托也可以封装多个方法，将其称之为委托链技术

    使用+运算符，我们将多个委托对象链接到一个委托对象实例上，使其成为多路广播委托实例。调用委托链时候，被绑定到委托链之中的每个委托都会被执行。

    7.4.2移除委托
既然能使用＋运算符把委托链添加到一个委托对象之上，自然也可以使用一来移除。下面代码演示了移除的过程:

    归纳总结:
本章我们讲解了游戏的关键知识点接口和委托，同时又介绍了委托链的使用。
**/
/*
 * 
 * 作用：
 * 
 * 
 * **/
