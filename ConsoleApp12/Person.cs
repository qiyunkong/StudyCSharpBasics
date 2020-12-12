using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    /*
     * 定义完接口之后，如果有类想继承该接口，则必须实现接口定义中的所有方法。
     * 继承方式于类是一样的,只需要使用:即可。代码如下所示:
     * **/
    class Person : ICustomCompare
    {
        private int age;
        public int Age {
            set { age = value; }
            get { return age; }
        }
        //实现接口方法
        public int CompareTo(object obj) {
            if (obj == null) {
                return 1;
            }
            Person otherp = (Person)obj;
            if (this.Age < otherp.Age)
            {
                return -1;
            }
            else {
                return 1;
            }

            return 0;
        }
    }
}
