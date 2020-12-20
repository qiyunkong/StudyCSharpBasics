using System;

namespace ConsoleApp17
{
    public class SingleTon {
        public static SingleTon instance;

        /*使用静态方法实现单例模式*/
        public static SingleTon getInstance() {
            if (instance == null) {
                instance = new SingleTon();
            }
            return instance;
        }

        /*使用静态方法实现单例模式*/
        public static SingleTon Instance {
                
            get {
                if (instance == null)
                {
                    instance = new SingleTon();
                }
                return instance;
            }
        }

        public void Print() {
            Console.WriteLine("123456");
        }
    }

    //泛型单例
    public class Animal<T> where T: new (){
        public static T instance;

        /*使用静态方法实现单例模式*/
        public static T getInstance()
        {
            if (instance == null)
            {
                instance = new T();
            }
            return instance;
        }

        /*使用静态方法实现单例模式*/
        public static T Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new T();
                }
                return instance;
            }
        }

        public void Print()
        {
            Console.WriteLine("123456");
        }
    }

    public class Cat : Animal<Cat> {
        /*由于Animal类继承是泛型类SinqleTon
         * 并且使用new() 进行类型参数的约束
         * 所以在使用时Cat.getInstance()类
         * 创建一个对象时
         * 要保证Cat类中有一个无参的构造函数
         * **/
        public void CatPrint() {
            Console.WriteLine("I am Cat");
        }
    }

    public class Dog : Animal<Dog> {

        public void DogPrint() {
            Console.WriteLine("I am Dog");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SingleTon.getInstance().Print();

            SingleTon.Instance.Print();

            //泛型单例
            Dog.getInstance().DogPrint();
            Cat.getInstance().CatPrint();


            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
