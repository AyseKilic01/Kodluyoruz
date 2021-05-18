using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_list.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Ayse");
            arrayList.Add("Kilic");
            arrayList.Add(26);
            arrayList.Add("Yasinda");

            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************");
            string[] colorList = { "Blue", "Yellow", "White", "Black" };
            arrayList.AddRange(colorList);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********************");

            // arrayList.Sort();
            arrayList.Reverse();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Clear();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
