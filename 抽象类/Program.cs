using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            Anmal an = new Dog();
            an.Name = "史亚民";
            an.Jiao(an.Name);
            Console.ReadKey();
        }
    }
    public abstract class Anmal
    {
        public abstract void Jiao(string name);
        public abstract string Name
        {
            get;
            set;
        }
    }
    public class Dog:Anmal
    {

        public override void Jiao(string name)
        {

            Console.WriteLine("你是一只小dog：{0}",this.Name);
        }

        public override string Name
        {
            get;
            set;
        }
     
    }
}
