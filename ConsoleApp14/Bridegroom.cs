using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    class Bridegroom
    {
        //自定义委托类
        public delegate void MarryHandler(string msg);

        //自定义委托类2
        public delegate void MarryHandler2(object s, MarryEventArgs msg);

        public string Message;

        //使用自定义委托事件，事件名为MarryEvent ，使用自定义的委托类型定义一个事件
        public event MarryHandler MarryEvent;

        public event MarryHandler2 MarryEvent2;

        //使用.net类库提供的委托EventHandler定义一个事件
        public event EventHandler MarryEventHandler;

        /*发布事件消息*/
        public void onMarriageComing(string msg) {
            if (MarryEvent != null) {
                //触发事件
                MarryEvent(msg);
            }
        }

        public void onMarriageComing2(string msg) {
            if (MarryEventHandler != null) {
                //赋值
                Message = msg;
                MarryEventHandler(this, new EventArgs());
            }
        }

        public void onMarriageComing3(string msg)
        {
            if (MarryEvent2 != null)
            {
                //赋值
                Message = msg;
                MarryEvent2(this, new MarryEventArgs(msg));
            }
        }

    }

   
}
