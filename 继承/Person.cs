using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    public class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { this._name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set { this._age = value; }
        }
        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { this._gender = value; }
        }
        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this._gender = gender;
        }
        public static void ceshi()
        {
            Console.WriteLine("你是哦我的");
        }
        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡！");
        }
        public Person()
        { }
    }
}
