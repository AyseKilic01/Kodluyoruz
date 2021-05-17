using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            for (int i = 0; i < 7; i++)
            {
                numberList.Add(i);
            }
            List<string> colorList = new List<string>();
            colorList.Add("blue");
            colorList.Add("white");
            colorList.Add("yellow");
            colorList.Add("brown");

            Console.WriteLine("Sayı Listesi Toplam değerler : " + numberList.Count);
            Console.WriteLine("Renk Listesi Toplam değerler : " + colorList.Count);

            foreach(var number in numberList)
            {
                Console.WriteLine(number);
            }
            foreach (var color in colorList)
            {
                Console.WriteLine(color);
            }

            colorList.Remove("blue");
            numberList.Remove(4);

            colorList.RemoveAt(1);
            numberList.RemoveAt(0);

           
            numberList.ForEach(number => Console.WriteLine(number));
            colorList.ForEach(color => Console.WriteLine(color));


            if (numberList.Contains(5))
            {
                Console.WriteLine("Found 5");
            }

            Console.WriteLine(colorList.BinarySearch("brown"));

            string[] array = { "Cat", "Dog", "Monkey", "Moo" };
            List<string> arrayList = new List<string>(array);
            arrayList.Clear();

            List<Users> users = new List<Users>();
            Users user1 = new Users();
            user1.Name = "Ayse";
            user1.SurName = "Kilic";
            user1.Age = 26;

            Users user2 = new Users();
            user2.Name = "Tugba";
            user2.SurName = "Kilic";
            user2.Age = 30;

            users.Add(user1);
            users.Add(user2);
            foreach(var i in users)
            {
                Console.WriteLine(i.Name + " " + i.SurName + " " + i.Age);
            }

            List<Users> usersList = new List<Users>();
            usersList.Add(new Users
            {
                Name = "Ayse",
                SurName = "Kilic",
                Age = 26
            });

            Console.ReadLine();
        }
    }
    public class Users
    {
       private string name;
       private string surname;
       private int age;

        public string Name { get => name ; set => name = value; }
        public string SurName { get => surname ; set => surname = value; }
        public int Age { get => age ; set => age = value; }
    }
}
