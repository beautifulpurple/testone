using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习FileStream操作多媒体文件
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"C:\Users\oldboy\Desktop\练习\7、使用FileStream来读写文件.avi";
            string detion = @"C:\Users\oldboy\Desktop\练习\7、使用FileStream来读写文件_new.avi";
           // CopyFile(source, detion);
            AppendFile(source, detion);
            Console.Write("成功！");
            Console.ReadKey();
        }
        //读写文件
        public static void CopyFile(string source, string detion)
        {
            using (FileStream fsr = new FileStream(source, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (FileStream fsw = new FileStream(detion, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] writecontent = new byte[1024 * 1024 * 5];
                    int shijiduqu;
                    do
                    {
                        shijiduqu = fsr.Read(writecontent, 0, writecontent.Length);
                        fsw.Write(writecontent, 0, shijiduqu);
                    } while (shijiduqu != 0);
                }
            }
        }
        public static void AppendFile(string source, string detion)
        {
            using (FileStream fsr = new FileStream(source, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (FileStream fsw = new FileStream(detion, FileMode.Append, FileAccess.Write))
                {
                    byte[] writecontent = new byte[1024 * 1024 * 5];
                    int shijiduqu;
                    do
                    {
                        shijiduqu = fsr.Read(writecontent, 0, writecontent.Length);
                        fsw.Write(writecontent, 0, shijiduqu);
                    } while (shijiduqu != 0);
                }
            }
        }
    }
}
