using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Abdelkader.DAL.Models
{
    public class Department  : BaseEntity
    {
  
        public string Name { get; set; }    

        public int code { get; set; }

        public DateTime DateOfCreation { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
