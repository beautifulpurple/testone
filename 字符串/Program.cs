using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //string aa = "Wfds12￥你的";
            //string bb = "ADdfd&$￥";
            //aa = aa.ToUpper();
            //bb = bb.ToLower();
            //Console.Write(aa);
            //string cc = "a b   c dfgh ,,, lkf +  -   mm";
            //char[] ff={' ',',','+','-'};
            //int gg = cc.Length;
            //string[] dd = cc.Split(ff);

            //string ss = "abcdefghijklmn";
            //char[] chararr = ss.ToCharArray();
            //chararr[0] = 'p';
            //ss = new string(chararr);
            //Console.WriteLine(ss);
            //Console.WriteLine(chararr[0]);
            //Console.WriteLine(chararr.Length);
            //Console.WriteLine("请输入第一个数字：");
            //string aa = Console.ReadLine();
            //Console.WriteLine("请输入第二个数字：");
            //string bb = Console.ReadLine();
            //bool b= aa.Equals(bb,StringComparison.OrdinalIgnoreCase);
            //Console.WriteLine(b);
            //string cesh = "史亚民啊啊哈哈啊";
            //if (cesh.Contains("史亚民"))
            //{
            //    cesh = cesh.Replace("史亚民", "徐华明");
            //}
            //Console.WriteLine(cesh);
            //string s = "de";
            //StringBuilder sb = new StringBuilder();
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for (int i = 0; i < 100000; i++)
            //{
            //    //s += DateTime.Now.ToString();
            //    sb.Append(DateTime.Now.ToString());
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);
            //Console.WriteLine(sw.ElapsedMilliseconds);
            //Console.WriteLine(sw.ElapsedTicks);
            string ss = "苏s州南师大智慧创苏州意产业有限公司";
            //if (ss.StartsWith("苏州"))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是的");
            //}
            //Console.WriteLine(ss);

            //Console.WriteLine(ss.IndexOf("苏州"));
            //string ssss = "";
            //Console.WriteLine(ssss);
            //ss = ss.Substring(2);
            //Console.WriteLine(ss);
            //string aa = "   nd ie   ";
            //aa = aa.Trim();
            //Console.Write(aa);
            //string[] arr = { "张三", "赵四", "王五", "赵六" };
            //string aa=string.Join("<>", arr);
            //Console.WriteLine(aa);
            //StringBuilder sb = new StringBuilder();
            string[] arr = File.ReadAllLines(@"C:\Users\oldboy\Desktop\新建文本文档 (3).txt", Encoding.Default);
            string[] temp;
            for (int i = 0; i < arr.Length; i++)
            {
                temp = arr[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                //if (temp[0].Length > 10)
                //{
                //    temp[0] = temp[0].Substring(0, 8);
                //}
                temp[0] = temp[0].Length > 10 ? temp[0].Substring(0, 8) : temp[0];//这样更装逼一些
                arr[i] = string.Join("|", temp);
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
