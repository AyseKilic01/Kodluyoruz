using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Manage
{
    public class ChooseClass
    {
        public ChooseClass()
        {
            Choose();
        }
       public static void Choose()
        {
            Console.WriteLine("Lütfen yapmak işlemi seçiniz : ");
            Console.WriteLine("********************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
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
            }
        }

        private static void List()
        {
            throw new NotImplementedException();
        }

        private static void Update()
        {
            throw new NotImplementedException();
        }

        private static void Delete()
        {
            throw new NotImplementedException();
        }

        private static void AddNew()
        {
            throw new NotImplementedException();
        }
    }
}
