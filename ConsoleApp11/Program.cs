using System;

namespace ConsoleApp11
{
    public class Horse : Animal {
        public Horse() {
            Console.WriteLine("I am Horse Constructer Function");
        }

        public override void Voice() {
            Console.WriteLine("Horse Voice Function");
        }

       
    }
    public class Sheep : Animal {

        public Sheep()
        {
            Console.WriteLine("I am Sheep Constructer Function");
        }

        /*使用new 关键字隐藏基类同名成员*/
        public new void Voice()
        {
            Console.WriteLine("Sheep Voice Function");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //封装
            Person p = new Person();
            p.Age = 130;
            Console.WriteLine("age is {0}", p.Age);
            
            //继承
            Horse horse = new Horse();
            horse.Age = 2;
            Sheep sheep = new Sheep();
            sheep.Age = 120;
            Console.WriteLine("马的年龄为{0}", horse.Age);
            Console.WriteLine("牛的年龄为{0}", sheep.Age);

            //多态
            horse.Voice();
            sheep.Voice();

            //掉用父类的方法
            ((Animal)horse).Voice(); //重写后无法调用父类的方法
            ((Animal)sheep).Voice(); //没有重写的类可以调用父类的方法





            Console.ReadKey();
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
 *  
 *  封装:
 *      封装指的是把类的内部实现隐藏起来，不让对象直接对其进行操作。C#提供了属性机制对内部的状态进行操作。
 *  在C#中，封装可以通过public, protected, private,internal来体现
 *      为什么使用封装，因为有的时候，我们把内部的数据定义为public之后，
 *  外部对象可以进行任意的操作，很可能导致不符合逻辑
 *      面向对象的封装特性，是一种保护状态数据完整性的方法，在面向对象编程中，
 *  应更多的定义私有字段，并且使用属性机制来对私有字段进行访问。下面代码演示了封装的具体操作。
 *  继承：
 *  在C#中，一个类可以继承另外一个已有的类（密封类除外），被继承的类称为基类（或者父类），继承的类称为派生类，子类将获得基类除构造函数和析构函数以外的所有成员。此外，静态类也不能被继承。
 *   例如，牛马羊都是动物，但是它们是不同种类的动物，除了动物的共性外，它们还具有各自的特点，如不同的用途，不同的发声方式等。我们可以把动物定义为牛羊马的父类。
 *   通过继承，程序可以实现对父类代码的复用。因为子类可以继承父类的所有成员，父类中定义的代码便不需要在子类中重复定义了。
 *  
 *  密封类
 *   密封类是指不能被继承的类，强行继承会产生编译错误。C#中使用sealed关键字来定义密封类，如下代码所示:
 *  
 *  
 *  子类的初始化顺序
 *   使用了继承之后，当我们初始化一个子类时，除了会调用子类的构造函数之外，同时也会调用基类的构造函数，子类的初始化顺序如下:
 *       1:初始化类的实例字段
 *       2:调用基类的构造函数，若没有基类，调用System.Object的构造函数。
 *       3:调用子类的构造函数。
 *       
 *      由于可以继承基类的成员，子类就有了相同的行为，但是有时子类的某些行为需要相互区别。子瑛需要覆盖父类中的方法来实现子类特有的行为，这就是多态。多态即相同类型的对象调用相同的方法却表现出不同行为的现象。
 *   使用virtual和override关键字实现方法重写
 *      只有基类成员声明为virtual(基类)或者abstract(抽象方法)时，
 *      才能被派生类重写;而子类想改变虚方法的实现行为，则必须使用override关键字。
 *      
 *   所有的类都是System.Object   
 *  
 *  
 *  
 * 
 * **/
