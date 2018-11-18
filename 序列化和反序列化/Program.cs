using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person("小明", 12, '男');
            //using (FileStream fs=new FileStream("测试序列化.txt",FileMode.OpenOrCreate,FileAccess.Write))
            //{
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fs, p);//其中实现了  将对象p序列化并通过流写到了文本文件中 所以不用调用文件流的write方法
            //}
            //Console.WriteLine("序列化成功！");
            Person p = null;
            using (FileStream fs=new FileStream("测试序列化.txt", FileMode.OpenOrCreate,FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                 p = (bf.Deserialize(fs)) as Person;//注意同样不用调用文件流的read方法
            }
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Gender);
            Console.ReadKey();
        }
    }
   [Serializable]
    public class Person
    {
        private string _name;
        private int _age;
        private char _gender;

        public Person(string _name, int _age, char _gender)
        {
            this._name = _name;
            this._age = _age;
            this._gender = _gender;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        public char Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }
    }
}
