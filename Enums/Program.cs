using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            int durum = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine(Days.Friday);
            if(durum > 20)
            {
                Console.WriteLine(" " + Days.Friday + " " + HavaDurum.Hot);
            }
            Console.ReadLine();
        }

    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    enum HavaDurum
    {
        Cold, Hot
    }
}
