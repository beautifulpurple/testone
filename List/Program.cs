using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            int[] arr = new int[5] { 2, 3, 4, 5, 6 };
            list.AddRange(arr);
            list.AddRange(list);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            List<int> list2 = arr.ToList();
            int[] arr2=list.ToArray();
            Console.ReadKey();
        }
      
    }
}
