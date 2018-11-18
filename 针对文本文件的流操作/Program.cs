using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 针对文本文件的流操作
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader=new StreamReader(@"C:\Users\oldboy\Desktop\文件流的练习.log",Encoding.Default))
            {
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
                
            }

            //using (StreamWriter sw=new StreamWriter(@"C:\Users\oldboy\Desktop\文件流的练习2563.log",true,Encoding.Default))
            //{
            //    sw.Write("今天天气好晴朗");
            //}
            Console.WriteLine("finish");
            Console.ReadKey();
        }
    }
}
