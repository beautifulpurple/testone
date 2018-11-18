using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类实现多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape yx = new YuanXing(5.32);
            yx.WriteResult(yx.ZhouChang(), yx.MianJi());
            Shape cfx = new ChangFangXing(2, 5);
            cfx.WriteResult(cfx.ZhouChang(), cfx.MianJi());
            Console.ReadKey();

        }
    }
    public abstract class Shape
    {
        public abstract double ZhouChang();
        public abstract double MianJi();
        public virtual void WriteResult(double zhouchang,double mianji)
        {
            Console.WriteLine("周长是：{0}，面积是：{1}", this.ZhouChang(), this.MianJi());
        }
    }
    public class YuanXing:Shape
    {
        public YuanXing(double r)
        {
            this.R = r;
        }
        private double _r;
        public double R
        {
            get { return this._r; }
            set { this._r = value; }
        }
        public override double ZhouChang()
        {
            return 2 * Math.PI * this.R;
        }

        public override double MianJi()
        {

            return Math.PI * this.R * this.R;
        }
    }
    public class ChangFangXing : Shape
    {
        public ChangFangXing(double chang, double kuan)
        {
            this.Kuan = kuan;
            this.Chang = chang;
        }
        private double _chang;

        public double Chang
        {
            get { return _chang; }
            set { _chang = value; }
        }
        private double _kuan;

        public double Kuan
        {
            get { return _kuan; }
            set { _kuan = value; }
        }
        public override double ZhouChang()
        {
            return (this.Kuan + this.Chang) * 2;
        }
        public override double MianJi()
        {
            return this.Chang * this.Kuan;
        }
    }
}
