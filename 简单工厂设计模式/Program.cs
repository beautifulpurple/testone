using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("请输入笔记本品牌：");
                string brand = Console.ReadLine();
                try
                {
                    if (brand.Equals("end", StringComparison.OrdinalIgnoreCase)) break;
                    NoteBook nb = GetBook(brand);
                    nb.SayHello();
                    Console.ReadKey();
                }
                catch (Exception)
                {

                }
            }
        }
        public static NoteBook GetBook(string brand)
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "HP":
                    nb = new HP();
                    break;
                case "Lenovo":
                    nb = new Lenovo();
                    break;
                case "IBM":
                    nb = new IBM();
                    break;
            }
            return nb;
        }
    }

    public abstract class NoteBook
    {
        public abstract void SayHello();
    }
    public class HP : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是惠普笔记本");
        }
    }
    public class Lenovo : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是联想笔记本");
        }
    }
    public class IBM : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是IBM笔记本");
        }
    }
}
