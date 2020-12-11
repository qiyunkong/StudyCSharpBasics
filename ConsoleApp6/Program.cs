using System;

namespace ConsoleApp6
{
    //声明一个枚举
    enum EnuDemo {
        Boy,
        Girl,
        Man = 5,
        Female
    }

    //声明一个结构体
    public struct Complex {
        public int real;
        public int imageinary;

        public Complex(int _real, int _imaginary)
        {
            this.real = _real;
            this.imageinary = _imaginary;
        }

        //运算符重载
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex result = new Complex();
            result.real = c1.real + c2.real;
            result.imageinary = c1.imageinary + c2.imageinary;
            return result;
                
        }

        //override 重写修饰符 
        public override string ToString()
        {
            return string.Format("我是加完后的real:{0}"+ "  "+ "我是加完后的imageinary:{1}", real, imageinary);
        }
             
    }


    class Program
    {
        public static void SwitchMethod(EnuDemo item)
        {
            switch (item) {
                case EnuDemo.Boy:
                    Console.WriteLine("It's boy");
                    break;
                case EnuDemo.Girl:
                    Console.WriteLine("It's girl");
                    break;
                case EnuDemo.Man:
                    Console.WriteLine("It's man");
                    break;
                case EnuDemo.Female:
                    Console.WriteLine("It's Female");
                    break;
                default:
                    Console.WriteLine("Invaild type");
                    break;

            }
        }

    static void Main(string[] args)
        {
            //使用运算符重载
            Complex c1 = new Complex(1, 2);
            Complex c2 = new Complex(3, 4);
            Complex sum = c1 + c2;
            Console.WriteLine(sum);


            //if-else 分支语句
            bool isFlay = true;
            int num = 1;
            if (isFlay)
            {
                Console.WriteLine("It's true");
            }
            else {
                Console.WriteLine("It's false");
            }

            if (isFlay && num > 2)
            {
                Console.WriteLine("It's true,It's num > 2");

            }
            else if (isFlay && num < 2)
            {
                Console.WriteLine("It's true,It's num < 2");
            }
            else {
                Console.WriteLine("Other");
            }

            //SwitchMethod
            Program.SwitchMethod(EnuDemo.Boy);
            




            Console.ReadKey();
        }
    }
}
