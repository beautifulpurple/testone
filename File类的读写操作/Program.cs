using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace File类的读写操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\oldboy\Desktop\智慧农村深化会议.docx";
            //byte[] aa = File.ReadAllBytes(path);
            //Console.WriteLine(Encoding.Default.GetString(aa));
            //File.WriteAllBytes(@"C:\Users\oldboy\Desktop\智慧农村深化会议2.docx", aa); 
            //Console.WriteLine("成功");
            ////byte[] buffer=File.ReadAllBytes(path);

            //EncodingInfo[] ne = Encoding.GetEncodings();
            //foreach (var item in ne)
            //{
            //    Console.WriteLine(item.DisplayName);
            //}
            ////string s = Encoding.Default.GetString(buffer);
            ////Console.WriteLine(s);
            ////Console.WriteLine("====================================");

            ////string[] s1 = File.ReadAllLines(path,Encoding.Default);
            ////foreach (var item in s1)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////Console.WriteLine("====================================");
            ////string s2 = File.ReadAllText(path,Encoding.Default);
            ////Console.WriteLine(s2);
            //string content = "你好，我是河南大学计算机学院的高材生";
            //byte[] bytecontent = Encoding.Default.GetBytes(content);
            //////以字节的形式向计算机中写入文本文件
            //File.WriteAllBytes(path, bytecontent);
            //string mp4content = @"C:\Users\oldboy\Desktop\优衣库.mp4";
            ////byte[] bytecontent = File.ReadAllBytes(mp4content);
            //File.WriteAllBytes(@"C:\Users\oldboy\Desktop\优衣库2.mp4", bytecontent);

            //Console.WriteLine("操作成功！");
            //byte[] buffer = new byte[1024 * 1024 * 5];
            ////while (true)
            ////{
            //File.WriteAllBytes(@"C:\Users\oldboy\Desktop\123.wmv", buffer);
            //// }
            //Console.WriteLine("chnegogng ");

            string path = @"C:\Users\oldboy\Desktop\智慧农村深化会议.docx";
            byte[] aa = File.ReadAllBytes(path);
            //将数组中每一个元素  按照我们指定的编码格式解析成字符串
            string bb = Encoding.GetEncoding("unicode").GetString(aa);
            Console.WriteLine(bb);
            Console.ReadKey();

        }
    }
  
}
