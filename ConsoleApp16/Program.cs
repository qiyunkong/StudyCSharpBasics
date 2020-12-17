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

            Console.WriteLine("max(1)="+max(1,2));

            Console.ReadKey();
        }

        public static T Max<T>(T t1,T t2) {
            if (t1 > t2)
            {
                return t1;
            }
            else {
                return t2;
            }
            return t1;
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

 * 
 * ***/
