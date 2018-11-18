using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public class Student
    {
        ~Student()
        { }
        public Student(string name, char gender, int age, int english, int math)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.English = english;
            this.Math = math;
        }
        public Student(string name, int age, int math)
            : this(name, '0', age, 0, math)//为了减少代码的赘余  使用this关键字调用最全的那个构造函数就好了
        { }
        private string _name;
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        private char _gender;
        public char Gender
        {
            get { return this._gender; }
            set { this._gender = value; }
        }
        private int _age;
        public int Age
        {
            get { return this._age; }
            set { this._age = value; }
        }
        private int _english;
        public int English
        {
            get { return this._english; }
            set { this._english = value; }
        }
        private int _math;
        public int Math
        {
            get { return this._math; }
            set { this._math = value; }
        }
    }
}
