using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Bridegroom bridegroom = new Bridegroom();

            Friend friend1 = new Friend("张三");
            Friend friend2 = new Friend("李四");
            Friend friend3 = new Friend("王五");

            //事件链 定义链
            /*订阅事件： +=*/
            bridegroom.MarryEvent += new Bridegroom.MarryHandler(friend1.SendMessage);
            bridegroom.MarryEvent += new Bridegroom.MarryHandler(friend2.SendMessage);
            bridegroom.MarryEvent += new Bridegroom.MarryHandler(friend3.SendMessage);

            /*取消事件： -=*/
            bridegroom.MarryEvent -= new Bridegroom.MarryHandler(friend3.SendMessage);

            //执行事件 发布消息
            Console.WriteLine("-------------start-----------");
            bridegroom.onMarriageComing("朋友们，英雄联盟，冲冲冲");
            Console.WriteLine("-------------end-------------");

            bridegroom.MarryEventHandler += new EventHandler(friend1.SendMessage);
            bridegroom.MarryEventHandler += new EventHandler(friend2.SendMessage);
            bridegroom.MarryEventHandler += new EventHandler(friend3.SendMessage);

            /*取消事件： -=*/
            bridegroom.MarryEventHandler -= new EventHandler(friend3.SendMessage);

            //执行事件 发布消息
            Console.WriteLine("-------------start-----------");
            bridegroom.onMarriageComing2("朋友们，英雄联盟，冲冲冲");
            Console.WriteLine("-------------end-------------");


            /*订阅事件： +=*/
            bridegroom.MarryEvent2 += new Bridegroom.MarryHandler2(friend1.SendMessage);
            bridegroom.MarryEvent2 += new Bridegroom.MarryHandler2(friend2.SendMessage);
            bridegroom.MarryEvent2 += new Bridegroom.MarryHandler2(friend3.SendMessage);

            /*取消事件： -=*/
            bridegroom.MarryEvent2 -= new Bridegroom.MarryHandler2(friend3.SendMessage);
            Console.WriteLine("-------------start-----------");
            bridegroom.onMarriageComing3("朋友们，英雄联盟，冲冲冲");
            Console.WriteLine("-------------end-------------");


            Console.ReadKey();
        }
    }
}
/*
 * 第八章:C#事件机制
    C#重要的特征不仅仅是委托，事件也是其中的一个，
    下面我们
    详细介绍一下事件机制。
8.1什么是事件
生活中，我们经常会说哪里发生了某件事，然后可能会针对这件事采取的措施。例如，你的好友过生日，你需要送礼物，结婚，你需要送红包。在C#中，过生日和结婚被当做事件来对待，而送礼和送红包是对事件作出的响应。
事件涉及两类角色一事件发布者和事件订阅者。当发生＋个事件的时候，事件发布者会发布事件，事件订阅者会接收事件已发生的通知，并且做出相应的处理。其中，触发事件的对象称之为事件发布者，捕获事件并且对其做出处理的称之为事件订阅者。
在上述例子中，好友充当了发布者，自己则充当了事件订阅者。

8.2使用事件8.2.1定义事件
在C#中定义事件与定义类的成员非常相似。下面给出一个事件的定义。
public event EventHandler birthday事件定义的结构为:
访问修饰符event委托类型事件名
访问修饰符一般定义为public,因为事件的订阅者需要对事件进行订阅与取消操作。定义为公共类型可以对其他类可见。事件定义还包含委托类型，它既可以是自定义的委托类型，也可以是.Net类库中预定义的委托类型EventHandler,我们会依次叙述。
8.2.2订阅和取消事件
事件订阅者需要订阅事件发布者发布的事件，以便在事件被触发时接收消息并且做出处理。我们可以使用+=来订阅事件，使用-=来取消订阅事件。
代码清单演示了使用自定义委托类型来定义事件的例子。
并使
用＋=和一=运算符分别对事件进行订阅和取消操作的方法。值得注意的是，事件处理函数的定义需要与自定义委托的定义保持一致。
除了使用自定义委托来定义事件外，还可以使用EventHandler来定义，也是实际开发中普遍采用的一种方式。具体使用如下
 * 
 * **/
