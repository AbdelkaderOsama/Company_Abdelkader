using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;
using Company_Abdelkader.DAL.Models;

namespace Company_Abdelkader.PL.Dtos
{
    public class CreateEmployeeDto 
    {
        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }

        
        public string Address { get; set; }

        [Range(20, 60 , ErrorMessage ="Age is between 22 to 60")]
        public int age { get; set; }


        public decimal salary { get; set; }

        public string Phone { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage ="Email is required")]
        public string Email { get; set; }

      

        public bool IsDeleted { get; set; }

        public bool ISActive { get; set; }

        public DateTime HiringDate { get; set; }

        public DateTime CreateAt { get; set; }

        [DisplayName("Department")]
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
