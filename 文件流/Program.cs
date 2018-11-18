using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 文件流
{
    class Program
    {
        /// <summary>
        /// 文件刘操作
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string str = "你是额";
            byte[] aa = Encoding.Default.GetBytes(str);
            File.WriteAllBytes(@"C:\Users\oldboy\Desktop", aa);
        }
    }
}
