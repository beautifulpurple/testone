using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 现实实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable ifly = new Bird();
            ifly.Fly();
            ifly.ISpeak();
            Bird b = new Bird();
            b.Fly();
            b.ISpeak();
            Console.ReadKey();
        }
    }
    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("我是一只小小鸟，我尽情的飞翔喽！");
        }
        void IFlyable.Fly()//显示实现接口  目的是解决方法的重名问题
        {
            Console.WriteLine("我是接口的方法");
        }
        public void ISpeak()
        {
            Console.WriteLine("我是接口的说话的能力");
        }

    }
    public interface IFlyable
    {
        void Fly();
        void ISpeak();
    }

}
