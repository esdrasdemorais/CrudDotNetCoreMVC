using System.Linq;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CrudDotNetCore.Models;
using MongoDB.Driver.Linq;
using MongoDB.Driver;

namespace CrudDotNetCore.Controllers
{
    public class EmployeeController : Controller
    {
        private MongoDbContext dbContext;

        public EmployeeController() {
            dbContext = new MongoDbContext();
        }

        public IActionResult Index()
        {
            // var client = new MongoClient(
            //     "mongodb+srv://testdotnet:lFyz93P9kqtdsVSl@esdrasmorais-bvesv.gcp.mongodb.net/test?connect=replicaSet&retryWrites=true&w=majority"
            // );
            // var database = client.GetDatabase("TestDotNet");
            // List<Employee> listEmployees = 
            //     database.GetCollection<Employee>("Employees").Find(m => true).ToList();
            return View(dbContext.GetAllEmployees().Result);
        }

        private EmployeeViewModel MapEmployeeViewModel(Employee employee)
        {
            return new EmployeeViewModel() {
                Employee = employee,
                Departments = employee.Departments
            };
        }

        [HttpGet]
        public IActionResult Edit(String id)
        {
            var entity = dbContext.GetEmployee(id).Result;

            return View(MapEmployeeViewModel(entity));
        }

        [HttpPost]
        public IActionResult Edit(EmployeeViewModel employeeViewModel)
        {
            Employee employee = MapEmployee(employeeViewModel);

            dbContext.Update(employee);

            return View(MapEmployeeViewModel(employee));
        }

        [HttpGet]
        public IActionResult Create()
        {
            // IEnumerable<Department> departments = new List<Department>() {
            //     new Department() { Name = "" },
            // };

            EmployeeViewModel employeeViewModel = new EmployeeViewModel() {
                Employee = new Employee(),
                Departments = new List<Department>()
            };

            // foreach (Department department in departments) {
            //     employeeViewModel.Departments.Add(department);
            // }
            
            return View(employeeViewModel);
        }

        private Employee MapEmployee(EmployeeViewModel employeeViewModel)
        {
            return new Employee() {
                Id = employeeViewModel.Employee.Id,
                Name = employeeViewModel.Employee.Name,
                Salary = employeeViewModel.Employee.Salary,
                Departments = employeeViewModel.Departments
            };
        }

        [HttpPost]
        public IActionResult Create(EmployeeViewModel employeeViewModel)
        {
            Employee employee = MapEmployee(employeeViewModel);

            dbContext.Create(employee);

            return RedirectToAction("Index", "Employee");
        }

        [HttpGet]
        public IActionResult Delete(String id)
        {
            dbContext.Delete(id);

            return RedirectToAction("Index", "Employee");
        }

        public IActionResult DepartmentEntryRow()
        {
            return PartialView("CreateDepartment");
        }
    }
}