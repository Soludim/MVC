using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private List<Employee> employee = new List<Employee>();

        public EmployeeRepository()
        {
            employee.Add(new Employee
            {
                Id = 1,
                Name = "Prince Quaye",
                Position = "Manager"
            });
            employee.Add(new Employee
            {
                Id = 2,
                Name = "James Asamoah",
                Position = "Cleaner"
            });
            employee.Add(new Employee
            {
                Id = 3,
                Name = "Newton Raphson",
                Position = "Director"
            });
            employee.Add(new Employee
            {
                Id = 4,
                Name = "Georgina Asare",
                Position = "CEO"
            });
        }

        public List<Employee> GetEmployees()
        {
            return employee;
        }

        public void RemoveEmployee(int id)
        {
            employee.RemoveAt(id - 1);
        }

    }
}
