using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company_Abdelkader.DAL.Models;

namespace Company_Abdelkader.BLL.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        //IEnumerable<Employee> GetAll();
        //Employee GetById(int id);

        //int Add(Employee model);
        //int Update(Employee model);
        //int Delete(Employee model);

        List<Employee> GetByName(string name);


    }
}
