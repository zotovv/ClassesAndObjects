using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John", "Smith");

            employee.Post = "manager";
            employee.Experience = 1;

            Console.WriteLine(employee.Name +" " + employee.Surname +" " + employee.Post.ToUpper());
            employee.ShowSalary();

            Console.ReadKey();
        }
    }
}
