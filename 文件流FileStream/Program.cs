using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 文件流FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = new FileStream(@"C:\Users\oldboy\Desktop\文件流的练习.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //byte[] fsbyte = new byte[1024 * 1024 * 5];//初始化5M   
            ////实际读取到的字节数
            //int truecount = fs.Read(fsbyte, 0, fsbyte.Length);
            //string fsReader = Encoding.Default.GetString(fsbyte, 0, truecount);
            //fs.Close();//关闭流
            //fs.Dispose();//释放所占用的资源
            //Console.WriteLine(fsReader);

            using (FileStream fsw = new FileStream(@"c:\Users\oldboy\Desktop\文件流的练习.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = "你还好吗  亲爱的";
                byte[] aa = Encoding.Default.GetBytes(str);
                fsw.Write(aa, 0, aa.Length);

            }
            Console.WriteLine("操作成功！");
            Console.ReadKey();
        }
    }
}
