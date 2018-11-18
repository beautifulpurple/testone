using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee();
            Manage ma = new Manage();
            Prommer po = new Prommer();
            Employee[] mearr = { em, ma, po };
            foreach (var item in mearr)
            {
                item.DaKa();
            }
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public virtual void DaKa()
        {
            Console.WriteLine("员工九点打卡");
        }
    }
    public class Manage : Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("经理十点打卡");
        }
    }
    public class Prommer : Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("程序员不打卡");
        }
    }
}
