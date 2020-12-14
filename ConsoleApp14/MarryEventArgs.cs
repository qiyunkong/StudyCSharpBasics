using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    //扩展类
    class MarryEventArgs:EventArgs
    {
        public string message;

        public MarryEventArgs(string msg) {
            message = msg;
        }
    }
}
