using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Ayse","Kilic");
            Employee employee1 = new Employee("Ayse","Kilic");
            Employee employee2 = new Employee("Ayse","Kilic");
            Employee employee3 = new Employee("Ayse","Kilic");
            Console.WriteLine("Çalışan Sayısı {0} ", Employee.EmployeeCount);
            Console.ReadLine();
        }
    }
    class Employee
    {
        private static int employeeCount;
        public static int EmployeeCount { get => employeeCount; }

        public string Name;
        public string surName;

        static Employee()
        {
            employeeCount = 0;
        }

        public Employee(string Name, string Surname)
        {
            this.Name = Name;
            this.surName = Surname;
            employeeCount++;

        }


    }
}
