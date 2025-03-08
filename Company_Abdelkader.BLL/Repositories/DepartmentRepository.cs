using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company_Abdelkader.BLL.Interfaces;
using Company_Abdelkader.DAL.Data.Contexts;
using Company_Abdelkader.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Company_Abdelkader.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly CompanyDbContext _context;

        public DepartmentRepository()
        {
            _context = new CompanyDbContext();
        }
        public IEnumerable<Department> GetAll()
        {
            
            return _context.Departments.ToList();
        }

        public Department GetById(int id)
        {
            
            return _context.Departments.Find(id);
        }

        public int Add(Department model)
        {
          
             _context.Departments.Add(model);
            return _context.SaveChanges();
        }

        public int Update(Department model)
        {

            _context.Departments.Update(model);
            return _context.SaveChanges();
        }

        public int Delete(Department model)
        {
            
            _context.Departments.Remove(model);
            return _context.SaveChanges();
        }

      

        

       
    }
}
