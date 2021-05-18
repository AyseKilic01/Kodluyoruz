using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> vs = new List<string>();
            string[] ch = {"a","e","ı","i","u","ü","o","ö"};
            string wordtence = Console.ReadLine();
            foreach(var item in wordtence)
            {
                for (int i = 0; i < ch.Length; i++)
                {
                    if (item.ToString() == ch[i])
                    {
                        vs.Add(ch[i]);
                    }
                }
            }
            vs.Sort();
            Console.WriteLine("Harfler : ");
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
