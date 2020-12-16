using System;

namespace ConsoleApp15
{
    public class TestClass {
        public int x;
        public int y;
    }
    public class RefClass{
        public int addNum;
    }
    public struct NestedREfTypeInValue {

        //结构体字段
        private TestClass classinvalue;

        //构造体构造函数
        public NestedREfTypeInValue(TestClass t)
        {
            classinvalue = t;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            //值类型
            int valuetype = 3;

            //reftype引用类型
            string reftype = "abc";



            int a = 2;

            //装箱
            object o = a;

            //拆箱
            int d = (int)o;
            Console.WriteLine(d);
            add(a);
            Console.WriteLine(a);

            RefClass refClass = new RefClass();
            refClass.addNum = 1;
            add(refClass.addNum);
            Console.WriteLine($"refclass.addNum:{refClass.addNum}");


            /*
             * string 特性分析
             * string 类型的变量一经初始化，它的值是不能能够更改的，
             * 当重新复制给变量时
             * 系统会重新开辟一块内存空间，用来存放新的数值
             * 而原有的数值没有发生变化
             * 
             * **/
            string str = "old String";
            ChangeStr(str);
            Console.WriteLine(str);


            /*
             * ref 必须初始化
             * 
             * 
             * **/
            int num = 1;
            Console.WriteLine("Before Changing, num:" + num);
            ChangeValue(out num);
            Console.WriteLine("After Changing, num:" + num);


            string strs = "Old string";
            Console.WriteLine("Before Changing, strs:" + strs);
            ChangeString(ref str);
            Console.WriteLine("After Changing strs:" + strs);

            Console.ReadKey();
           
        }

        public static void add(int addNum) {
            addNum = addNum + 1;
            Console.WriteLine($"addNum:{addNum}");
        }

        /*out 必须在变量中赋值 out是清空意思*/
        public static void ChangeValue(out int num) {
            num = 10;
            Console.WriteLine("num: " + num);
        }

        public static void ChangeString(ref string str) {
            str = "new str";
            Console.WriteLine("str: " + str);
        }

        public static void ChangeStr(string oldStr) {
            oldStr = "new String";
            Console.WriteLine("oldStr:" + oldStr);
        }
    }
}
/*
 * 第九章:深入理解类型
#中的类型主要分为两大类，值类型和引用类型。本章将详细分析两种类型，并且讨论它们之间的转换方法。
9.1 什么是值类型和引用类型
值类型主要包括简单类型、枚举类型、结构体类型。值类型被分配在线程的堆栈上，变量保存的就是数据本身。引用类型被分配在托管堆上，变量保存的是实例数据的内存地址。
9.1.2值类型和引用类型的区别
值类型通常被分配到线程的堆栈上，而引用类型则被分配到托管堆上。值类型由操作系统管理，引用类型的管理由垃圾回收器管理。
管理主要是指对内存空间进行分配和释放。下面的例子我们分析一下内存结构:


    栈                          托管堆
valuetype=3                   
reftype                            abc 

值类型和引用变量类型，变量本身都是存储在堆栈中的。区别在于实际数据的存储位置:值类型的实际数据存储在堆栈中，引用类型存储在托管堆中。比如通过家庭住址找到某个人。
但是，嵌套结构需要单独定义，包括值类型嵌套引用类型和引用类型中定义了值类型。



    综合分析:
值类型总会被分配在它声明的地方，声明的是局部变量，将被分配到栈上;声明为引用成员时，被分配到托管堆上;而引用类型的实例总是分配到托管堆上。
值类型继承自ValueType, ValueType又继承自System.0bject;而引用类型直接继承于System. 0bject;
值类型不受GC控制，作用域结束时候，会被操作系统释放，从而减少托管堆压力。引用类型的内存管理由GC完成。
值类型默认值为0，引用类型为null。
 * 
 * 
 * **/

/**
9.1.3 两大类型之间转换一装箱和拆箱
装箱指的是将值类型转换为引用类型的过程。而拆箱指的是将引用类型转换为值类型。
装箱过程中，
系统会在托管堆里面生成一个副本;而拆箱则是从托管堆中将引用类型所指向的已经装箱的数据复制回值类型对象的过程。


    装箱操作分为以下3个步骤
(1）内存分配:在托管堆中分配内存空间用来存放复制的实际数据
(2）完成实际数据的复制:将值类型实例的实际数据复制到新分配的内存中
(3）地址返回:将托管堆中的对象地址返回给引用类型变量


    拆箱分为以下三个步骤
(1）检查实例:首先检查进行拆箱操作的引用类型是否为null，如果为null则抛出异常，如果不为null则继续检查变量是否和拆箱后的类型是同一类型。
(2）地址返回:返回已装箱变量的实际数据部分的地址
(3）数据复制:将托管堆中的实际数据复制到栈中
由于装箱和拆箱存在数据复制，所以比较耗费资源。最好使用范型进行编程。


9.2参数传递问题剖析
    9.2.1:值类型参数按照值传递
参数分为形参和实参，具体不再细说，下面分析代码。

    9.2.2 引用类型参数按照值传递
    当传递的类型是引用类型时，传递和操作的目标是指向对象的地址，
    而传递的实际内容是对地址的复制。由于地址指向的是实参的值，当方法对地址进行操作时，会对原来的发生修改。



这个主要是因为string具有不变型，一旦被赋值，则它就是不可更改的。
方法oldstr=“New String”代码表面上对内容进行了修改，但是由于string具有不变性，
系统此时会重新分配一块内存空间存放NewString字符串，然后把分配的地址赋值给oldstr变量。
所以，方法完成之后，str所指向的仍然是原来的old string，而oldstr则指向了New String。


    9.2.3 值类型和引用类型参数的按引用传递
不管是值类型还是引用类型，你都可以使用ref或者out关键字来实现参数的按引用传递。
    并且在按照引用类型进行传递时候，方法的定义和调用必须显式的使用ref或者out关键字，不可以将它们省略，否则引起编译错误。
在按照引用传递时，不管参数是值类型还是引用类型，本质都是一样的，都是通过ref或者out告诉编译器，方法传递的是参数地址,而非参数本身。

    题---


    ref, out, in三者的区别:
ref:使用ref关键字进行值类型和引用类型参数的按引用传递时，传入的参数必须先被初始化,否则编译出错，在方法的内部可以不对传入的参数进行内部处理，传入的参数也可以被使用。
out:使用out关键字进行值类型和引用类型参数的按引用传递时，传入的参数可以不先被初始化(如果传入的参数被事先初始化，在传入的过程中也会被清空) ,编译不会出错，但在方法的内部可以必须对传入的参数完成初始化操作，传入的参数才能够被使用，否则编译出错。
in:默认的传递方式，向函数内部传送值，传入的过程中参数的初始值不会被改写。
为方便理解，举一个简单的例子:
lIn:过程不会改写ln的内容
out:传入的值不会被过程所读取,但过程可以写ref:传入的值,过程会读,也会写
例如:你把布料送到裁缝的一个收料箱(裁缝用这个区别是哪家客户)
in:这块布料,不能动,我取时还要原样(我取时会要不要这块料,是我自己的事,你管不着,但你不能把这块料做任何改变.你只能看这块料的质地、色彩等等.你要想改变这块料.那自已去照这块料
*/
