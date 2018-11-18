using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.Name = "大可乐";
            //p.Age = 27;
            //p.Sex = '女';
            //p.DaKeLe();
            //new Person { Name = "aa", Age = -23, Sex = '女' }.DaKeLe();//我认为这是代码的链式写法 就像jquery的链接写法一样
            //Person.Aa = "lol";
            //Person.M2();
            JiSuan js = new JiSuan(100.2);
            js.ShowPrice();
            Console.ReadKey();

        }
    }
}
