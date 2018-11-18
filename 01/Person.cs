using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public class Person
    {
        string _name;
        public string Name
        {
            get
            {
                if (this._name != "大可乐")
                {
                    this._name = "大可乐";
                }
                return this._name;
            }
            set { this._name = value; }
        }
        private char _sex;

        public char Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        private int _age;
        public int Age
        {
            get { return this._age; }
            set
            {
                if (value < 0 || value > 100)
                    this._age = 0;
                this._age = value;
            }
        }

        private static string _aa;
        public static string Aa
        {
            get { return _aa; }
            set { _aa = value; }
        }
        public void DaKeLe()
        {
            Console.WriteLine("我是{0}，今年{1}岁，是{2}生", this.Name, this.Age, this.Sex);
        }
        public static void M2()
        {
            Console.WriteLine("这是一个静态类的练习{0}",Aa);
        }
    }
}
