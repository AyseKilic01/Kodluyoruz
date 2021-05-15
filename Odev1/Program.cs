using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            TotalSense();
            Call();
            Console.ReadLine();
        }

       public static void Call()
        {
            int call = 0;
            int value = 0;
            Console.WriteLine("Pozitif bir baslangic sayisi giriniz : ");
            call = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pozitif bir mode sayisi giriniz : ");
            value = Convert.ToInt32(Console.ReadLine());
            if (call > 0 && value > 0)
            {
                CallDizi(call);
                CallValue(call, value);
                CallString(call);
            }
            else
            {
                Call();
            }
        }
        public static void CallDizi(int value)
        {
            int sayi = 0;
            int[] dizi = new int[value];
            Console.WriteLine("Pozitif bir sayı giriniz : ");
            for (int i = 0; i < dizi.Length; i++)
            {
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 0)
                {
                    dizi[i] = sayi;
                }
                else
                {
                    Console.WriteLine("Pozitif bir deger girmelisiniz. Degerleri bastan giriniz !!! ");
                    CallDizi(value);
                }
            }
            Console.WriteLine("2 ye bolunebilen girdiginiz sayilar : ");
            foreach (var i in dizi)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void CallValue(int value1, int value2)
        {
            int sayi = 0;
            int[] dizi = new int[value1];
            Console.WriteLine("Pozitif bir sayı giriniz : ");
            for (int i = 0; i < dizi.Length; i++)
            {
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 0)
                {
                    dizi[i] = sayi;
                }
                else
                {
                    Console.WriteLine("Pozitif bir deger girmelisiniz. Degerleri bastan giriniz !!! ");
                    CallDizi(value1);
                }
            }
            Console.WriteLine(value2 + " e bolunebilen girdiginiz sayilar :");
            foreach (var i in dizi)
            {
                if (i % value2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void CallString(int value)
        {
            string[] dizi = new string[value];
            Console.WriteLine("Kelimelerinizi Giriniz : ");
            for (int i= 0; i < dizi.Length; i++){
                dizi[i] = Console.ReadLine();
            }
            Console.WriteLine("Sondan basa dogru girmis oldugunuz kelimeler : ");
            for(int i=dizi.Length-1; i>=0; i--)
            {
                Console.WriteLine(dizi[i]);
            }
        }

        public static void TotalSense()
        {
            Console.WriteLine("Cumlenizi yaziniz :");
            string sense = Console.ReadLine();
            string son = "";
            Console.WriteLine("Total harf sayisi : " + sense.Trim().Length);
            Console.WriteLine("Kelimeler : ");
            foreach (var i in sense)
            {
                if(i.ToString() != " ")
                {
                    son += i; 
                }
                Console.WriteLine(son);
                son = "";
            }
            
        }

    }
}
