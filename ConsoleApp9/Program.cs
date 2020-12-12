using System;

namespace ConsoleApp9
{
    //声明结构体
    public struct PersonStruct
    {
        public string name;
        public string mobilePhone;
        public DateTime birthday;
    }
    //声明类
    public class PersonClass
    {
        public string name;
        public string mobilePhone;
        public DateTime birthday;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //无参数构造函数
            Person p1 = new Person();
            Console.WriteLine($"p1.age={p1.age},p1.name={p1.name}");

            //有参数构造函数
            Person p2 = new Person(10, "云空");
            p2.Age = 20;
            Console.WriteLine($"p2.Age={p2.Age},p2.age={p2.age}");


            //使用单例模式
            Person p3 = Person.getInstance();
            Person p4 = Person.getInstance();
            Console.WriteLine(p3 == p4); //true 
            Console.WriteLine($"Person.id={Person.id}");
            p3.age = 123;
            Console.WriteLine($"p3.age={p3.age},p4.age={p4.age}"); //123

            //查看执行顺序
            Single s = new Single();

            //索引器使用
            List list = new List();
            list[0] = 12;
            list[1] = 13;
            list[2] = 14;
            Console.WriteLine("list[0]=" + list[0]);
            Console.WriteLine("list[1]=" + list[1]);
            Console.WriteLine("list[2]=" + list[2]);


            PersonStruct ps1, ps2; //与类一样，但是可以不new
            ps1.name = "张飞";
            ps1.mobilePhone = "1355366108";
            ps1.birthday = DateTime.Now.AddYears(-10);
            ps2 = ps1; //将p1的值赋值p2
            //由于是值类型，因此赋值等于全部复制到p2栈空间
            ps2.name = "关羽";
            Console.WriteLine("ps1.name:" + ps1.name); //输出 张飞
            Console.WriteLine("ps2.name:" + ps2.name); //输出 关羽

            PersonClass ps3 = new PersonClass();
            ps3.name = "张飞";
            ps3.mobilePhone = "1355366108";
            ps3.birthday = DateTime.Now.AddYears(-10);

            PersonClass ps4 =  ps3;
            //是由于引用类型，因此两个对象向的是同一个地址（堆空间）
            ps4.name = "关羽";

            Console.WriteLine("ps3.name:" + ps3.name); //输出 关羽
            Console.WriteLine("ps4.name:" + ps4.name); //输出 关羽


            Console.ReadLine();
        }
    }
}

//笔记
/*
    一个类的成员：
        字段
		属性
        方法
            访问器
            构造函数
            析构函数
        索引器    
*/


//实例构造函数
/*
    1.可以用访问修饰符进行修饰
    2.无返回值
    3.无数据类型
    4.方法名与类名相同
    5.可以有参数
    6.可以实现方法重载
    7.如果没有显式的定义构造函数，默认会产生一个无参的构造函数，如果显示的定义了构造函数，将会把系统默认的构造函数进行覆盖
*/
//静态构造函数
/*
    1.静态构造函数不能使用任何访问修饰符
    2.静态构造函数不能带有任何参数
    3.静态构造函数只会执行一次
    4.不能直接调用静态构造函数
    5.程序院无法直接控制静态构造函数调用时机
*/
//析构函数
/*
    1.不能在结构体中定义析构函数，只能在类中
    2.一个类只能有一个
    3.无法继承或者重载析构函数
    4.无法显示的调用析构函数,由垃圾回收自动调用
    5.析构函数即没有修饰符也没有参数
*/
//方法重载
/*
    1.方法名相同
    2.参数列表不同，包括：参数个数，参数类型，参数顺序
*/

//方法重写
/*
    1.方法名相同
    3.继承关系
    2.参数列表相同，包括：参数个数，参数类型，参数顺序
*/
//索引器
/*
    当类中具有数组成员时，可以让我们像访问
    数组成员一样的访问
*/
//结构体类的区别
/*
 * 
 * 1:类定义使用class，结构体使用struct
 * 2:结构体中不可对声明的字段进行初始化，类可以
 * 3:结构体中，无论我们有没有定义构造函数，隐式的构造函数一直存在
 * 4:结构体不能显式的定义无参数的构造函数
 * 5:结构体构造函数必须为所有的字段赋值
 * 6:创建结构体对象可以不使用new，类必须得使用
 * 7:结构体不能继承结构或者类，但可以实现接口；但不能继承结构，可以实现接口
 * 8:类是引用类型，结构体是值类型
 * 9:结构体不能定义析构函数，类可以
 * 10:不能用abstract或者sealed修饰结构体，而类可以。
*/
