using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合小练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> liststr = new List<string>();
            //string[] str = { "tom", "lili", "json", "mali", "xiaoli" };
            //liststr.AddRange(str);
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(liststr[0]);
            //    liststr.RemoveAt(0);
            //}
            List<string> aa = new List<string>() { "one", "two" };
            aa.Add("three");
            for (int i = 0; i < aa.Count; i++)
            {
                Console.WriteLine(aa[i]);
            }
            Console.ReadKey();
        }
    }
}
