using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList集合
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(true);
            //list.Add("张三");
            //list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            //list.AddRange(list);
            ////list.Remove(1);//删除第一个匹配的元素
            ////list.RemoveAt(2);//根据下标去删除元素
            ////list.RemoveRange(0, 3);//根据下标去删除一定数量的元素
            ////list.Sort();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //int[] aa = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> listarr = aa.ToList();
            //for (int i = 0; i < listarr.Count; i++)
            //{
            //    Console.Write(listarr[i]);
            //}
            //list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            //int a = (int)list[0];
            //ArrayList al = new ArrayList(10);
            //Console.WriteLine(al.Count);
            ArrayList als = new ArrayList();
            Random rd = new Random();
            int temp;
            for (int i = 0; i < 10; i++)
            {
                temp = rd.Next(0, 10);
                if (!als.Contains(temp))
                {
                    als.Add(temp);
                }
                else
                {
                    i--;
                }
            }
            for (int i = 0; i < als.Count; i++)
            {
                Console.WriteLine(als[i]);
            }
            Hashtable ht = new Hashtable();
            ht.Add("nide", "zhi");
            Console.ReadKey();
        }
    }
}
