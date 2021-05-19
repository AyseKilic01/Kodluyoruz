using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee{ID = 1, Name = "Ayse", surName = "Kilic", Department ="IT" };
            employee.GetAll();
            Console.ReadLine();
        }
    }
    public class Employee
    {
        public int ID;
        public string Name;
        public string surName;
        public string Department;
        public void GetAll()
        {
            Console.WriteLine("Personel ID = {0} " , ID);
            Console.WriteLine("Personel Adı = {0} " , Name);
            Console.WriteLine("Personel Soyadı = {0} " , surName);
            Console.WriteLine("Personel Departmanı = {0} " , Department);
        }
        
    }
}
