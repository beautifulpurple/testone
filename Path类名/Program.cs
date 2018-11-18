using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Path类名
{
    class Program
    {
        //Path类啊
        static void Main(string[] args)
        {
            string path = @"E:\项目\ASP.Net资料大全\自学程序各种笔记\C#基础教程(传智播客视频)\传智播客\笔记.docx";
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.GetFullPath(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.ReadKey();
        }
    }
}
