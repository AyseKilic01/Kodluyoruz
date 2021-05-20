using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulations
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.ID = 1;
            student.Name = "Ayse";
            student.SurName = "Kilic";
            student.StudentList();
            Console.ReadLine();
        }
    }
    public class Student
    {
        private int _ID;
        private string _Name;
        private string _SurName;

        public int ID
        {
            get => _ID;
            set => _ID = value;
        }
        public string Name {
            get => _Name;
            set => _Name = value;
        }
        public string SurName {
            get => _SurName;
            set => _SurName = value;
        }
        public Student(int id, string name, string surname)
        {
            ID = id;
            SurName = surname;
            Name = name;
        }
        public Student() { }

        public void StudentList()
        {
            Console.WriteLine("************ Listed ****************");
            Console.WriteLine(ID + " " + Name + " " + SurName);
        }
    }
}
