using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串练习
{
    class Program
    {
        static void Main(string[] args)
        {
            string aa = "abcdefg";
            char[] bb = aa.ToCharArray();
            //方法一：
            Array.Reverse(bb);
            //方法二：   通过把数组中的元素进行换位置
            //char temp;
            //for (int i = 0; i < bb.Length/2; i++)
            //{
            //    temp=bb[i];
            //    bb[i]=bb[bb.Length-1-i];
            //    bb[bb.Length-1-i]=temp;
            //}
            aa = new string(bb);
            Console.WriteLine(aa);
            int[] intarr = { 1, 3, 5, 2, 4 };
            Array.Sort(intarr);
            foreach (var item in intarr)
            {
                Console.WriteLine(item);
            }

            string dd = "hello c sharp";
            string[] ff = dd.Split(' ');
            Array.Reverse(ff);
            dd = string.Join(" ", ff);
            Console.WriteLine(dd);
            string email = "liuke@163.com";
            string name = email.Substring(0, email.IndexOf("@"));
            string yuming = email.Substring(email.IndexOf('.') + 1);
            Console.WriteLine("用户名：{0}   域名：{1}", name, yuming);

            string gg = "abcdabcabcdacaddda";
            char[] hh = gg.ToCharArray();
            int ii;
            for (int i = 0; i < hh.Length; i++)
            {
                ii = hh[i].ToString().Contains('a') ? i : -1;
                if (ii > -1)
                {
                    Console.WriteLine(i);
                }
            }
            //挺好的封装 感觉是
            int index = -1;
            do
            {
                index = gg.IndexOf('a', index + 1);
                if (index > -1)
                {
                    Console.WriteLine(index);
                }

            } while (index > -1);

            string tt = "老牛很邪恶";

            tt = tt.Contains("邪恶") ? tt.Replace("邪恶", "**") : tt;
            Console.WriteLine(tt);
            string[] rrr = { "老牛", "是的", "老人", "好的" };
            string mb = string.Join("|", rrr);
            Console.ReadKey();
        }
    }
}
