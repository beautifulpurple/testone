using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person[] p = new Person[10];
            //Random r = new Random();
            //int temp;
            //for (int i = 0; i < p.Length; i++)
            //{
            //    temp = r.Next(1, 7);
            //    switch (temp)
            //    {
            //        case 1:
            //            p[i] = new Strdent();
            //            break;
            //        case 2:
            //            p[i] = new Teacher();
            //            break;
            //        case 3:
            //            p[i] = new MeiNv();
            //            break;
            //        case 4:
            //            p[i] = new ShuaiGe();
            //            break;
            //        case 5:
            //            p[i] = new XiaoHong();
            //            break;
            //        case 6:
            //            p[i] = new Person();
            //            break;
            //    }
            //}
            //for (int i = 0; i < p.Length; i++)
            //{
            //    if (p[i] is Strdent)
            //    {
            //        (p[i] as Strdent).StudentSayHi();
            //    }
            //    else if (p[i] is Teacher)
            //    {
            //        (p[i] as Teacher).TeacherSayHi();

            //    }
            //    else if (p[i] is MeiNv)
            //    {
            //        (p[i] as MeiNv).MeiNvSayHi();
            //    }
            //    else if (p[i] is ShuaiGe)
            //    {
            //        (p[i] as ShuaiGe).ShuaiGeSayHi();
            //    }
            //    else if (p[i] is XiaoHong)
            //    {
            //        (p[i] as XiaoHong).XiaoHongSayHi();
            //    }
            //    else
            //    {
            //        p[i].PeosonSayHi();
            //    }
            //}

            Person pp = new Teacher();//子类可以转换父类对象
            if (pp is Teacher)
            {
                Teacher ss = pp as Teacher;//如果父类装的是子类对象  那么可以将父类转换成子类对象
                ss.TeacherSayHi();
            }
            else
            {
                Console.WriteLine("转换失败");
            }
            
            Console.ReadKey();
        }
    }
    public class Person
    {
        public void PeosonSayHi()
        {
            Console.WriteLine("我是人类");
        }
    }
    public class Strdent : Person
    {
        public void StudentSayHi()
        {
            Console.WriteLine("我是学生");
        }
    }
    public class Teacher : Person
    {
        public void TeacherSayHi()
        {
            Console.WriteLine("我是教师");
        }
    }
    public class MeiNv : Person
    {
        public void MeiNvSayHi()
        {
            Console.WriteLine("我是美女");
        }
    }
    public class ShuaiGe : Person
    {
        public void ShuaiGeSayHi()
        {
            Console.WriteLine("我是帅哥");
        }
    }
    public class XiaoHong : Person
    {
        public void XiaoHongSayHi()
        {
            Console.WriteLine("我是小红");
        }
    }
}
