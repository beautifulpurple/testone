using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 随便练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "测试1");
            dic.Add(2, "测试2");
            foreach (var item in dic.Values)
            {
                Console.WriteLine(item);
            }
            foreach (KeyValuePair<int,string> item in dic)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            Console.ReadKey();
        }
    }
}
