using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            ArrayList asalList = new ArrayList();
            ArrayList nonAsalList = new ArrayList();
            int sayi;
            bool asal = true;
            for (int i = 0; i < 3; i++)
            {
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi <= 0)
                {
                    Console.WriteLine("Lütfen pozitif sayı giriniz !!!");
                    break;
                }
                else
                {
                    for (int j = 2; j < sayi; j++)
                    {
                        if (sayi % j == 0)
                        {
                            asal = false;
                        }
                    }
                    if(asal == true)
                    {
                        asalList.Add(sayi);
                        asal = true;
                    }
                    else
                    {
                        nonAsalList.Add(sayi);
                        asal = true;
                    }
                    }
            }
           
            asalList.Sort();
            nonAsalList.Sort();
            Console.WriteLine("Asal Sayılar : ");
            foreach(var item in asalList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Asal Olmayan Sayılar : ");
            foreach (var item in nonAsalList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Toplam Asal Sayı :  " +asalList.Count);
            Console.WriteLine("Toplam Asal Olmayan Sayı : "+nonAsalList.Count);
            int ortalama = 0;
            foreach(var item in asalList)
            {
                ortalama += Convert.ToInt32(item);
            }
            if(asalList.Count > 0)
            Console.WriteLine("Asal sayıların ortalaması : "+ ortalama/asalList.Count);
            ortalama = 0;
            foreach (var item in nonAsalList)
            {
                ortalama += Convert.ToInt32(item);
            }
            Console.WriteLine("Asal sayıların ortalaması : " + ortalama / nonAsalList.Count);
            Console.ReadLine();
        }
    }
}
