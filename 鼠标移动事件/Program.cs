using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;

namespace 鼠标移动事件
{
    class Program
    {
        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int x, int y);
        static void Main(string[] args)
        {

            //System.Diagnostics.Process.Start("http://www.douyutv.com/");//打开指定网页

            ////System.Diagnostics.Process.Start("http://www.baidu.com/");
            //Thread.CurrentThread.Join(5000);
            ////干掉后台进程
            //foreach (System.Diagnostics.Process process in System.Diagnostics.Process.GetProcessesByName("Firefox"))
            //{
            //    process.Kill();
            //}
            DoIt();
            Console.ReadKey();
        }
        private static void DoIt()
        {
            while (true)
            {
                SetCursorPos(100, 100);//设置鼠标垫的位置
                Thread.Sleep(1000);
                SetCursorPos(200, 150);
                Thread.Sleep(1000);
                SetCursorPos(300, 200);
                Thread.Sleep(1000);
                SetCursorPos(400, 250);
                Thread.Sleep(1000);
                SetCursorPos(500, 300);
                Thread.Sleep(1000);
                SetCursorPos(600, 350);
                Thread.Sleep(1000);
                SetCursorPos(700, 400);
                Thread.Sleep(1000);
                SetCursorPos(800, 550);
                Thread.Sleep(1000);
                SetCursorPos(900, 600);
                Thread.Sleep(1000);
                SetCursorPos(1000, 650);
                Thread.Sleep(1000);
                SetCursorPos(1100, 700);
                Thread.Sleep(1000);
            }
        }
    }
}
