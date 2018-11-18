using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01;
namespace 命名空间
{
    class Program
    {
        static void Main(string[] args)
        {
            new Person { Name = "lala", Age = 12, Sex = '女' }.DaKeLe();
            Console.ReadKey();
        }
    }
}
