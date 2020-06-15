using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectAndFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lstEmployees = new List<Employee>();
            Employee emp1 = new Employee() { Employeeid = 1, Birthdate = new DateTime(1948, 12, 8), Firstname = "Nancy", Lastname = "Davolio" };
            Employee emp2 = new Employee() { Employeeid = 2, Birthdate = new DateTime(1952, 2, 19), Firstname = "Andrew", Lastname = "Fuller" };
            Employee emp3 = new Employee() { Employeeid = 3, Birthdate = new DateTime(1963, 8, 30), Firstname = "Janet", Lastname = "Leverling" };
            Employee emp4 = new Employee() { Employeeid = 4, Birthdate = new DateTime(1937, 9, 19), Firstname = "Margaret", Lastname = "Peacock" };
            Employee emp5 = new Employee() { Employeeid = 5, Birthdate = new DateTime(1955, 3, 4), Firstname = "Robert", Lastname = "Buchanan" };
            Employee emp6 = new Employee() { Employeeid = 6, Birthdate = new DateTime(1963, 7, 2), Firstname = "Michael", Lastname = "Suyama" };
            Employee emp7 = new Employee() { Employeeid = 7, Birthdate = new DateTime(1960, 5, 29), Firstname = "Robert", Lastname = "King" };
            Employee emp8 = new Employee() { Employeeid = 8, Birthdate = new DateTime(1958, 1, 9), Firstname = "Laura", Lastname = "Callahan" };
            Employee emp9 = new Employee() { Employeeid = 9, Birthdate = new DateTime(1966, 1, 27), Firstname = "Anne", Lastname = "Dodsworth" };

            lstEmployees.Add(emp1);
            lstEmployees.Add(emp2);
            lstEmployees.Add(emp3);
            lstEmployees.Add(emp4);
            lstEmployees.Add(emp5);
            lstEmployees.Add(emp6);
            lstEmployees.Add(emp7);
            lstEmployees.Add(emp8);
            lstEmployees.Add(emp9);


            //Single
            var single = lstEmployees.Single(x => x.Firstname == "Anne");

            //SingleOrDefault
            var singleOrDefault = lstEmployees.SingleOrDefault(x => x.Employeeid == 9);

            //First
            var first = lstEmployees.First(x => x.Firstname == "Robert");

            //FirstOrDefault
            var firstOrDefault = lstEmployees.FirstOrDefault(x => x.Firstname == "xyz");
        }
    }

    class Employee
    {
        public int Employeeid { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public DateTime Birthdate { get; set; }

    }
}
