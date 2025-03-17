using Company_Abdelkader.BLL.Interfaces;
using Company_Abdelkader.BLL.Repositories;
using Company_Abdelkader.DAL.Models;
using Company_Abdelkader.PL.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Company_Abdelkader.PL.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        private IDepartmentRepository _DepartmentRepository;

        public EmployeeController(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository )
        {
            _employeeRepository = employeeRepository;
            _DepartmentRepository = departmentRepository;
        }

        [HttpGet] //Employee
        public IActionResult Index()
        {


            var employees = _employeeRepository.GetAll();

            //dictionary = 3 proberty
            //1: ViewData

            //ViewData["Message"] = "Hellow from ViewData";
            //2: ViewBag
            ViewBag.Message = "Hellow From ViewBag";

            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var departments =  _DepartmentRepository.GetAll();
            ViewData["departments"] = departments;
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateEmployeeDto model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    Name = model.Name,
                    Address = model.Address,
                    age = model.age,
                    Phone = model.Phone,
                    salary = model.salary,
                    Email = model.Email,
                    CreateAt = model.CreateAt,
                    ISActive = model.ISActive,
                    IsDeleted = model.IsDeleted,
                    HiringDate = model.HiringDate,
                    DepartmentId = model.DepartmentId,
            
                    
                };
                var count = _employeeRepository.Add(employee);

                if (count > 0)
                {
                    RedirectToAction(nameof(Index));
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int? id, string ViewName = "Details")

        {
            if (id == null) return BadRequest("invalid id");

            var employee = _employeeRepository.GetById(id.Value);

            if (employee is null) return NotFound(new { statuscode = 404, message = $"employee id {id} is not found " });

            return View(ViewName, employee);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            //if (id == null) return BadRequest("invalid id");

            //var department = _departmentRepository.GetById(id.Value);

            //if (department is null) return NotFound(new { statuscode = 404, message = $"department with id {id} is not found " });

            return Details(id, "Edit");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromRoute] int id, Employee employee)
        {

            if (ModelState.IsValid)
            {
                if (id != employee.Id) return BadRequest();

                var count = _employeeRepository.Update(employee);
                if (count > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }


            return View(employee);

        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            //if (id == null) return BadRequest("invalid id");

            //var department = _departmentRepository.GetById(id.Value);

            //if (department is null) return NotFound(new { statuscode = 404, message = $"department with id {id} is not found " });

            return Details(id, "Delete");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([FromRoute] int id, Employee employee)
        {

            if (ModelState.IsValid)
            {
                if (id != employee.Id) return BadRequest();

                var count = _employeeRepository.Delete(employee);
                if (count > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }


            return View(employee);

        }

    }
}
