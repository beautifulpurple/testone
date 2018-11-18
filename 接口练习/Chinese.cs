using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口练习
{
    class Chinese:IPersonable,IAnmailable
    {
        public void NengLi()
        {
            Console.WriteLine("我是中国人，我能吃喝拉撒！");
        }
        public void NiMei()
        {
            Console.WriteLine("大家其实都是一种动物！");
        }
    }
}
