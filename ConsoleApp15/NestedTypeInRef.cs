using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    //引用类型嵌套定义值类型
    public class NestedTypeInRef
    {
        //valuetype 作为引用类型的一部分被分配到托管堆上
        private int valuetype = 3;
        public void method() {
            //c 被分配到线程堆中
            char c = 'c';
            
        }
       
    }
}

