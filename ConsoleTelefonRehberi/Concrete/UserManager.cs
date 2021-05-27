using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTelefonRehberi.Concrete
{
   public class UserManager
    {
        public UserManager()
        {
                
        }
        private string name;
        private string surname;
        private string phone;
        public string _name { get=>name; set=>name = value; }
        public string _surname { get=>surname; set=>surname = value; }
        public string _phone { get=>phone; set=>phone = value; }
        public UserManager(string Name, string SurName, string Phone)
        {
            this._name = Name;
            this._surname = SurName;
            this._phone = Phone;
        }
        List<UserManager> userManagers = new List<UserManager>();
        public void Add(string name, string surname, string phone)
        {
           

           
        }
        public void List()
        {
            for (int i = 0; i <5; i++)
            {
                Console.WriteLine(_name + " " + _surname + " " + _phone);
            }
        }

    }
}
