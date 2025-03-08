using System.ComponentModel.DataAnnotations;

namespace Company_Abdelkader.PL.Dtos
{
    public class DetailsDepartmentDto
    {
        [Required(ErrorMessage = "Code is Required")]
        public int code { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date is Required")]
        public DateTime DateOfCreation { get; set; }
    }
}
