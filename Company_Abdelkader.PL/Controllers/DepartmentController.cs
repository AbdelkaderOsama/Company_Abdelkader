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
        public IActionResult Details()
        {

            return View();
        }


    }
}
