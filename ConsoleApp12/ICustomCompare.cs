using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    /*
     * 接口的定义和类的定义非常类似，只是使用的关键字不一样而已
     * 类的定义使用class，接口的定义使用interface。如下所示:
     * **/
    interface ICustomCompare
    {
        /*
         * 这就是一个简单的接口定义，并没有定义任何方法。
         * 下面向该接口添加一个比较方法，
         * 让所有继承该接口的类都可以实现这个方法添加方法之后的代码如下所示:
         * **/
        int CompareTo(object obj);
        /*
         * 在接口中定义方法不能添加任何访问修饰符，默认为公有，添加了之后，则会报错。
         * **/

        /*
         *  注意事项：
         *   在接口中除了可以定义方法外，还可以包含属性、事件、索引器、或者这四类的任意组合。
         *   但是接口不能包含字段、运算符重载、实例构造函数、析构函数。
         *   接口中也不能使用static关键字。
         * 
         * **/
    }
}
