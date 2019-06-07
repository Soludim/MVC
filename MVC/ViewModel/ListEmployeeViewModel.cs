using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.ViewModel
{
    public class ListEmployeeViewModel
    {
        [TempData]
        public string Message { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
