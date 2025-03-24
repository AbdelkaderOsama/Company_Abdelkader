using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Abdelkader.BLL.Interfaces
{
    public interface IUnitOfWork
    {
         IDepartmentRepository departmentRepository { get;  }
         IEmployeeRepository employeeRepository { get;  }
    }
}
