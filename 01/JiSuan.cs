using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public class JiSuan
    {
        private double _distance;
        public double Distance
        {
            get { return _distance; }
        }
        public JiSuan(double distance)
        {
            if (distance<0)
            {
                distance = 0;
            }
            this._distance = distance;
        }
        private double _price;
        public double Price
        {
            get
            {
                if (this._distance>0&&this._distance<=100)
                {
                    return this._distance * 1.0;
                }
                else if (this._distance>100&&this._distance<=200)
                {
                    return this._distance * 0.95;
                }
                else if (this._distance > 200)
                {
                    return this._distance * 0.80;
                }
                else
                {
                    return this._distance * 0.70;
                }
            }
        }
        public void ShowPrice()
        {
            Console.WriteLine("{0}公里的价格是{1}元", this.Distance, this.Price);
        }
    }
}
