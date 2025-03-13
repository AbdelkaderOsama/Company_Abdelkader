using Company_Abdelkader.BLL.Interfaces;
using Company_Abdelkader.BLL.Repositories;
using Company_Abdelkader.DAL.Models;
using Company_Abdelkader.PL.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Company_Abdelkader.PL.Controllers
{
    //mvc controller 
    public class DepartmentController : Controller
    {
        private IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpGet] // /Department/index
        public IActionResult Index()
        {
            

            var departments = _departmentRepository.GetAll();

            return View(departments);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateDepartmentDto model)
        {
            if (ModelState.IsValid)
            {
                var department = new Department()
                {
                    Name = model.Name,
                    code = model.code,
                    DateOfCreation = model.DateOfCreation
                };
                var count = _departmentRepository.Add(department);
                
                if(count > 0)
                {
                    RedirectToAction(nameof(Index));
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int? id)
            
        {
            if (id == null) return BadRequest("invalid id");

            var department = _departmentRepository.GetById(id.Value);

            if (department is null) return NotFound(new { statuscode = 404, message = $"department with id {id} is not found " });

            return View(department);
        }

        [HttpGet]
        public IActionResult Edit (int? id)
        {
            if (id == null) return BadRequest("invalid id");

            var department = _departmentRepository.GetById(id.Value);

            if (department is null) return NotFound(new { statuscode = 404, message = $"department with id {id} is not found " });

            return View(department);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromRoute]int id,Department department)
        {

            if (ModelState.IsValid)
            {
                if(id  != department.Id) return BadRequest();
               
                var count  = _departmentRepository.Update(department);
                if (count > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            

            return View(department);

        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null) return BadRequest("invalid id");

            var department = _departmentRepository.GetById(id.Value);

            if (department is null) return NotFound(new { statuscode = 404, message = $"department with id {id} is not found " });

            return View(department);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([FromRoute] int id, Department department)
        {

            if (ModelState.IsValid)
            {
                if (id != department.Id) return BadRequest();

                var count = _departmentRepository.Delete(department);
                if (count > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }


            return View(department);

        }


    }
}
