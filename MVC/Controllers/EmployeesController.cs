using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository _repository;

        public EmployeesController(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        
        public IActionResult Index()
        {
            var viewModel = new ViewModel.ListEmployeeViewModel()
            {
                Message = "Displaying List of Employees",
                Employees = _repository.GetEmployees()
            };

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _repository.RemoveEmployee(id);
            return RedirectToAction("Index");
        }
    }
}