using System;
using System.Collections.Generic;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int result = CompareClass<int>.CompareValue(1, 2);
            Console.WriteLine($"result = {result}");

            //按照ASll值进行比较
            string resultStr = CompareClass<string>.CompareValue("adc", "d");
            Console.WriteLine("resultStr = {0}", resultStr);

            CompareClass<int>.testGenericList();
            //CompareClass<int>.testGenericArrayList();


            /*开发泛型
             *  定义的时候指定泛型参数，调用的时候
             *  没有指定具体的数据类型
             * **/
            Type t = typeof(Dictionary<,>);
            Console.WriteLine("Is open?" + t.ContainsGenericParameters);


            /*
             * 封闭泛型
             *  定义的时候指定了泛型参数，调用的时候
             *  为泛型指定了具体的数据类型
             * **/
            Type t2 = typeof(DictionaryStringKey<string>);
            Console.WriteLine("Is open?" + t2.ContainsGenericParameters);

            //
            TypeWithStaticField<int>.OutField();
            TypeWithStaticField<string>.OutField();
            TypeWithStaticField<Guid>.OutField();


            /*非泛型类：
             * 对于非泛型类，不管创建多少个实例对象
             * 同时都只存在一个静态字段
             * **/
            NonGenericStaticClass.Print();
            NonGenericStaticClass.Print();

            /*泛型类：
             * 每一个泛型的实例对象都有自己的静态数据 
             * 或者说每一个封闭泛型都具有自己的静态数据
             * 同样的泛型参数 调用一次
             * **/
            GenericStaticClass<int>.Print();
            GenericStaticClass<string>.Print();
            GenericStaticClass<int>.Print();


            Console.ReadKey();
        }

        
    }
}

/*
 * 第十章:C#范型编程
10.1为什么使用泛型编程
我们在编写程序时，经常遇到两个模块的功能非常相似，只是一个是处理int数据，
另一个是处理string数据，或者其他自定义的数据类型，但我们没有办法，只能分别写多个方法处理每个数据类型，
因为方法的参数类型不同。有没有一种办法，在方法中传入通用的数据类型，这样不就可以合并代码了吗?泛型的出现就是专门解决这个问题的。
读完本篇文章，你会对泛型有更深的了解。
我们先简单的看一下下面的需求及其解释，后面我们会详细讲解里面的具体特性。
我们现在要求实现一个栈，这个栈只能处理int数据类型:

   1．他是类型安全的。实例化了int类型的栈，就不能处理string类型的数据，其他数据类型也一样。
2.无需装箱和折箱。这个类在实例化时，按照所传入的数据类型生成本地代码，本地代码数据类型已确定，所以无需装箱和折箱。
3.无需类型转换。
10.2怎么使用泛型
泛型的意思就是Generic,它所代表的是通用类型，可以代替任意的数据类型，使得类型参数化，从而达到了只需要一个方法就可以操作多种数据的目的。
泛型将方法实现行为与方法操作的数据类型分离，实现了代码重用，下面的代码演示了泛型的作用。

    
    泛型不仅仅可以实现代码的重用，减少了装箱和拆箱的过程。
泛型是避免损失的有效方法。
下面我们通过代码测试了使用泛型和不适用泛型的执行时间。

 10.3全面解析泛型
    10.3.1类型参数
        泛型分为开放泛型和封闭泛型。其中开放类型是指包含类型参数的泛型，但是未绑定的类型;封闭类型是指已经为每一个
    都传递了数据类型。下面的代码演示了是开放还是封闭的方法.

   ---代码----
   上述代码使用t.ContainsGenericParameters属性来判断类型对象是否包含未被实际类型替代的类型参数。
   存在则返回true，表示为开放类型，不存在则返回false，表示为封闭类型。
    静态数据类型是属于类型的，如果定义了一个静态字段x，则不
    管之后创建了多少个该类的实例，也不管派生多个实例，都只存在一











    10.4类型参数约束
在前面我们实现的泛型之中，我们使用了where T: lComparable的代码，其中where语句用来使类型继承于IComparable接口，从而对类型参数进行约束。下面我们来看看泛型常见的约束。
10.4.1基类约束
基类约束有两个功能。首先，它允许在泛型类中使用自由约束指定的基类所定义的成员。通过提高基类约束，编译器将知道所有的类型实参都拥有由指定的基类所定义的成员。基类约束的第二个功能是，确保只使用支持指定基类的类型实参。这意味着对于任意给定的基类约束，类型实参必须是基类本身或者是派生于该基类的类。基类约束使用如下形式的where子句:
where T: base-class-name
其中，T是类型形参的名称，base-class-name是基类的名称。只能指定一个基类。

    10.4.2接口约束
接口约束是指定某个类型实参必须实现的接口。它的两个主要功能与基类约束一样，允许开发人员在泛型类中使用接口的成员;确保只能使用实现了特定接口的类型实参。也就是说对任何给定的接口约束，
类型实参必须是接口本身或者实现了该接口的类。接口约束使用的where子句具有以下形式:

 * 
 * ***/
