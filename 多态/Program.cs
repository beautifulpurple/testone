using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("盘古");
            Chinese ch = new Chinese("姚明");
            American am = new American("科比");
            Person[] parr = { p, ch, am };
            foreach (var item in parr)
            {
                item.SayHello();
            }
            Console.ReadKey();
        }
    }
    public class Person
    {
        private string _name;
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public Person(string name)
        {
            this.Name = name;
        }
        public virtual void SayHello()
        {
            Console.WriteLine("我是人类，我的远古名字是：{0}", this.Name);
        }
    }
    public class Chinese : Person
    {
        public Chinese(string name)
            : base(name)
        { }
        public override void SayHello()
        {
            Console.WriteLine("我是中国人，我的名字是：{0}", this.Name);
        }
    }
    public class American : Person
    {
        public American(string name)
            : base(name)
        { }
        public override void SayHello()
        {
            Console.WriteLine("我是美国人，我的名字是：{0}", this.Name);
        }
    }
}
