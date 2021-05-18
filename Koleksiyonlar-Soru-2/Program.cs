using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            int[] vs1 = new int[3];
            int[] vs2 = new int[3];
            int gecici = 0;
            int toplam1 = 0;
            int toplam2 = 0;
            for(int i=0; i<array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int j=0; j<array.Length; j++)
            {
                for(int z=0; z<array.Length; z++)
                {
                    if (array[j] < array[z])
                    {
                        gecici = array[j];
                        array[j] = array[z];
                        array[z] = gecici;
                    }
                }
            }
            Console.WriteLine("******************************************");
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

                for (int j = 0; j < 3; j++)
                {
                    toplam1 += array[j];
                }
            for (int j = 0; j < array.Length; j++)
            {
                for (int z = 0; z < array.Length; z++)
                {
                    if (array[j] > array[z])
                    {
                        gecici = array[j];
                        array[j] = array[z];
                        array[z] = gecici;
                    }
                }
            }

            for (int j = 0; j < 3; j++)
                {
                    toplam2 += array[j];
                }
          
            Console.WriteLine("Toplamalar : " + toplam1 + "  " + toplam2);
            Console.WriteLine("******************************");
            Console.WriteLine("İlk üçünün toplam ortalama : " + (toplam1 / vs1.Length));
            Console.WriteLine("Son üçünün toplam ortalama : " + (toplam2 / vs2.Length));
            Console.ReadLine();

        }
    }
}