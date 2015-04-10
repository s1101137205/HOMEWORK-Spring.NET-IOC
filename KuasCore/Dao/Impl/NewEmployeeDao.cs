using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuasCore.Models;

namespace KuasCore.Dao.Impl
{
    class NewEmployeeDao : IEmployeeDao
    {
        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employess = new List<Employee>();

            Employee employess1 = new Employee();
            employess1.Id = "cc";
            employess1.Name = "Nacy";
            employess1.Age = 18;
            employess.Add(employess1);

            Employee employess2 = new Employee();
            employess2.Id = "aa";
            employess2.Name = "Jess";
            employess2.Age = 25;
            employess.Add(employess2);

            return employess;
        }

        public Employee GetEmployeeById(string id)
        {

            Employee employee = null;

            if ("cc".Equals(id))
            {
                employee = new Employee();
                employee.Id = "cc";
                employee.Name = "Nacy";
                employee.Age = 18;
            }

            return employee;
        }
    }
}
