using ConsoleTelefonRehberi.Concrete;
using System;

namespace ConsoleTelefonRehberi
{
    class Program
    {
        #region objects
       static UserManager userManagers = new UserManager();
        #endregion

        static void Main(string[] args)
        {
            Choose();
            Console.ReadLine();
        }
        static void Choose()
        {
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
        }
      static void AddNew()
        {
            Console.Write("  Lütfen isim giriniz             : ");
            string _name = Console.ReadLine();
            Console.Write("  Lütfen soyisim giriniz          : ");
            string _surName = Console.ReadLine();
            Console.Write("  Lütfen telefon no giriniz       : ");
            string _phone = Console.ReadLine();
            Users user6 = new Users
            {
                Name = _name,
                SurName = _surName,
                Phone = _phone
            };
            userManagers.Add(user6);
            Console.WriteLine("Kullanıcı Eklendi. ");
            List();
            CikisControl();
        }
        static void Delete()
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string deleteV = Console.ReadLine();
            userManagers.Delete(deleteV);
            CikisControl();
        }
        static void Update()
        {
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string searchh = Console.ReadLine();
            userManagers.Search(searchh);
            Console.Write("Lütfen kişinin yeni adını giriniz: ");
            string updateV = Console.ReadLine();
            userManagers.Update(updateV,searchh);
        }
        public static void List()
        { 
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("********************************"); 
            userManagers.List();
            CikisControl();

        }
        static void Search()
        {
            Console.Write("Lütfen numarasını aramak istediğiniz kişinin adını ya da soyadını giriniz: ");
            string searchh = Console.ReadLine(); 
            userManagers.Search(searchh);
            CikisControl();

        }
        static void CikisControl()
        {
            Console.WriteLine("Çıkış yapmak ister misiniz ?");
            Console.WriteLine("Çıkış için 1 e basın : " + "   " + " Devam etmek için 2 e basın");
           int control = Convert.ToInt32(Console.ReadLine());
            if(control == 1)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Choose();
            }
        }
    }
}
