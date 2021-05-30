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
            Create();
        }
      void Create()
        {
            Users user1 = new Users
            {
                Name = "Ayse",
                SurName = "Kılıç",
                Phone = "05434952339"
            }; Users user2 = new Users
            {
                Name = "Fatma",
                SurName = "Kılıç",
                Phone = "05434952339"
            }; Users user3 = new Users
            {
                Name = "Nurdan",
                SurName = "Kılıç",
                Phone = "05434952339"
            }; Users user4 = new Users
            {
                Name = "Hulusi",
                SurName = "Kılıç",
                Phone = "05434952339"
            };Users user5 = new Users
            {
                Name = "Elif",
                SurName = "Kılıç",
                Phone = "05434952339"
            };
            Add(user1);
            Add(user2);
            Add(user3);
            Add(user4);
            Add(user5);
        }
        List<Users> users = new List<Users>();
        public void Add(Users entity)
        {
            users.Add(entity);
        }
        public void List()
        {
            foreach(var item in users)
            {
                Console.WriteLine(item.Name + " " + item.SurName + " " + item.Phone);
            }
        }

        public void Search(string searchh)
        {
           var degerler = users.Where(x => x.Name == searchh || x.SurName == searchh).ToList();
            foreach (var item in degerler)
            {
                Console.WriteLine(item.Name + " " + item.SurName + " " + item.Phone);
            }
        }

        public void Delete(string deleteV)
        {
            var itemToRemove = users.Single(r => r.Name == deleteV);
            users.Remove(itemToRemove);
            foreach (var i in users)
            {
                Console.WriteLine(i.Name + " " + i.SurName + " " + i.Phone);
            }
        }

        public void Update(string updateV, string searchh)
        {
            var degerler = users.Where(x => x.Name == searchh || x.SurName == searchh);
            foreach (var item in degerler)
            {
                item.Name = updateV;
            }
            foreach(var i in users)
            {
                Console.WriteLine(i.Name + " " + i.SurName + " " + i.Phone);
            }
        }
    }
}
