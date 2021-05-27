using ConsoleTelefonRehberi.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTelefonRehberi
{
    class Program
    {
        static void Create()
        {
            UserManager user1 = new UserManager("Ayse", "Kilic", "054345895");
            UserManager user2 = new UserManager("Fatma", "Kilic", "054345895");
            UserManager user3 = new UserManager("Hayriye", "Kilic", "054345895");
            UserManager user4 = new UserManager("Kazim", "Kilic", "054345895");
            UserManager user5 = new UserManager("Sultan", "Kilic", "054345895");

        }
        static void Main(string[] args)
        {
            Create();
            Console.WriteLine("Lütfen yapmak işlemi seçiniz : ");
            Console.WriteLine("********************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddNew();
                    break;
                case 2:
                    Delete();
                    break;
                case 3:
                    Update();
                    break;
                case 4:
                    List();
                    break;
                case 5:
                    Search();
                    break;
               
            }
            Console.ReadLine();
        }

      static void AddNew()
        {
            Console.Write("  Lütfen isim giriniz             : ");
            string Name = Console.ReadLine();
            Console.Write("  Lütfen soyisim giriniz          : ");
            string SurName = Console.ReadLine();
            Console.Write("  Lütfen telefon no giriniz       : ");
            string Phone = Console.ReadLine();
            UserManager user = new UserManager();
            user.Add(Name,SurName,Phone);
        }
        static void Delete()
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string Name = Console.ReadLine();
        }
        static void Update()
        {
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string Name = Console.ReadLine();
        }
        public static void List()
        { 
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("********************************");
            UserManager userManagers = new UserManager();
            userManagers.List();

        }
        static void Search()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("********************************");
        }
        static void Add()
        {
         
          
        }
    }
}
