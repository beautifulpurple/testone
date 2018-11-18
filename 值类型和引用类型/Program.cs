using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "我的";
            string s2 = s1;
            s2 = "你的"; 
            Console.WriteLine(s1);
            Console.ReadKey();
        }
    }
}
