using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodluyoruz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Giriniz : ");
            string name = Console.ReadLine();
            Console.WriteLine("Soy isminizi Giriniz : ");
            string surname = Console.ReadLine();
            Console.WriteLine("Adınız: " + name + " Soyadınız: " + surname);
            Console.ReadLine();

        }
    }
}
