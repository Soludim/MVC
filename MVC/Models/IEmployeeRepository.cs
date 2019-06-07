using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
  public  interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
        void RemoveEmployee(int id);
    }
}
