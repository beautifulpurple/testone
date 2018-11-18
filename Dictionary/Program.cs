using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "you");
            //dic.Add(2, "me");
            //dic.Add(3, "she");
            //foreach (KeyValuePair<int, string> kv in dic)
            //{
            //    Console.WriteLine("{0}----------------{1}", kv.Key, kv.Value);
            //}
            //将一个数组中的奇数放到一个集合中，再将偶数放到另一个集合中
            //最终将两个集合合并成一个集合，并且奇数显示在左边  偶数显示在右边
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    list2.Add(arr[i]);
                }
                else
                    list1.Add(arr[i]);
            }
            list1.AddRange(list2);
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            //提示用户输入一个字符串 通过foreach循环将用户输入的字符串赋值给一个字符数组
            string userWrite = null;
            do
            {
                Console.WriteLine("请输入：");
                userWrite = Console.ReadLine();
            } while (string.IsNullOrEmpty(userWrite) || string.IsNullOrWhiteSpace(userWrite));

            char[] charArr = new char[userWrite.Length];
            int index=0;
            foreach (var item in userWrite)
            {
                charArr[index] = item;
                index++;
            }

            foreach (var item in charArr)
            {
                Console.WriteLine("结果是：\t"+item);
            }
            //统计Welcome to china 中每个字符出现的次数  不考虑大小写
            string str = "welcome to china";
            Dictionary<char, int> dic = new Dictionary<char, int>();//int的默认值是0
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')//空字符串跳过
                {
                    continue;
                }
                if (dic.ContainsKey(str[i]))
                {
                    dic[str[i]]++;
                }
                else
                {
                    dic[str[i]] = 1;
                }
            }
            foreach (KeyValuePair<char,int> kv in dic)
            {
                Console.WriteLine("字母{0}出现的次数是：{1}", kv.Key, kv.Value);
            }
            Console.ReadKey();
        }

    }
}
