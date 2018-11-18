using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File类
{
    class Program
    {
        static void Main(string[] args)
        {
            //string file = @"C:\Users\oldboy\Desktop\文件类练习.doc";
            //File.Create(file);

            // File.Delete(file);
            //File.Copy(file, @"C:\Users\oldboy\Desktop\啦啦.doc");
            File.Move(@"C:\Users\oldboy\Desktop\啦啦.doc", @"f:\HAHHAHHAAHA.doc");
            Console.ReadKey();
            //1024byte=1kb;
            //1024kb=1M;
            //024M=1G;
            //1024G=1T;
            //1024T=1PT;
        }
    }
}
