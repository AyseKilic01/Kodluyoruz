using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Ayse");
            dictionary.Add(2, "Kilic");
            dictionary.Add(3, "26");
            Console.WriteLine(dictionary[1]);
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
            foreach(var item in dictionary.Keys)
            {
                Console.WriteLine(item);
            }
            foreach(var item in dictionary.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(dictionary.Count);
            Console.ReadLine();
        }
    }
}
