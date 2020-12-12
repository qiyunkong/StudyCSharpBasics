using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class List
    {
        private int[] intarray = new int[10];

        /*
         * 索引器
         * 好处：
         * 当类中具有数组成员时，可以让我们像访问
         * 数组成员一样的访问
         * */
        public int this[int index]
        {
            get { return intarray[index]; }
            set { intarray[index] = value; }
        }
    }
}
