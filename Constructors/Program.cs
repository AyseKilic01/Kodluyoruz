using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Ayse", "Kilic", "IT");
            employee.GetAll();
            Console.ReadLine();
        }
    }
    public class Employee
    {
        public int _ID;
        public string _Name;
        public string _surName;
        public string _Department;
        public Employee(int ID, string name, string surname, string department)
        {
            this._ID = ID;
            this._Name = name;
            this._surName = surname;
            this._Department = department;
        }
        public void GetAll()
        {
            Console.WriteLine("Personel ID = {0} ", _ID);
            Console.WriteLine("Personel Adı = {0} ", _Name);
            Console.WriteLine("Personel Soyadı = {0} ", _surName);
            Console.WriteLine("Personel Departmanı = {0} ", _Department);
        }

    }
}
