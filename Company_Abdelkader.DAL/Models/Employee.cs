using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Company_Abdelkader.DAL.Models
{
  public class Employee : BaseEntity
    {
        public string Name { get; set; }
      
        public string Address { get; set; }
        public int age { get; set; }
        public decimal salary { get; set; } 

        public string Phone { get; set; }

        public string Email { get; set; }

        

        public bool IsDeleted { get; set; }

        public bool ISActive { get; set; }

        public DateTime HiringDate { get; set; }

        public DateTime CreateAt { get; set; }


    }
}
