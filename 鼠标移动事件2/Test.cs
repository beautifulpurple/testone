using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 鼠标移动事件2
{
    public class Test
    {
        public void Method1()
        {
            while (true)
            {
                Console.WriteLine(DateTime.Now.ToString() + "_" + Thread.CurrentThread.ManagedThreadId.ToString());
                Thread.CurrentThread.Join(100);//阻止设定时间
            }
        }


        public void Method2(object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString() + "_" + Thread.CurrentThread.ManagedThreadId.ToString());
        }


        public void Method3(Object state)
        {
            Console.WriteLine(DateTime.Now.ToString() + "_" + Thread.CurrentThread.ManagedThreadId.ToString());
        }
    }
}
