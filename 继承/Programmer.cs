using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    public class Programmer : Person
    {
        private string _do;
        public string Do
        {
            get { return _do; }
            set { this._do = value; }
        }
        public Programmer(string Do, string name, int age, char gender)
            : base(name, age, gender)
        {
            this.Do = Do;
            this.Age = age;
            this.Gender = gender;
            this.Name = name;
        }
        public void aa()
        {
            Console.WriteLine("123");
        }
        public Programmer()
        { }
    }
}
