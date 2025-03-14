using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company_Abdelkader.BLL.Interfaces;
using Company_Abdelkader.DAL.Data.Contexts;
using Company_Abdelkader.DAL.Models;

namespace Company_Abdelkader.BLL.Repositories
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        private readonly CompanyDbContext _context;

        public EmployeeRepository(CompanyDbContext context)
        {
            _context = context;

        }
        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.Find(id);
        }


        public int Add(Employee model)
        {
             _context.Employees.Add(model);
            return _context.SaveChanges();  
        }

        public int Update(Employee model)
        {
            _context.Employees.Update(model);
            return _context.SaveChanges();
        }

        public int Delete(Employee model)
        {
            _context.Employees.Remove(model);
            return _context.SaveChanges();
        }

       

       

       
    }
}
