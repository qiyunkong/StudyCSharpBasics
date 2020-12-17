using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    public static class TypeWithStaticField<T> 
    {
        public static string field;
        public static void OutField()
        {
            Console.WriteLine(field + typeof(T).Name);    
        }
    }
}
