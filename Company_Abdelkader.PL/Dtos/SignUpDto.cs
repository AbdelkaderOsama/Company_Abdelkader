using System.ComponentModel.DataAnnotations;

namespace Company_Abdelkader.PL.Dtos
{
    public class SignUpDto
    {
        [Required (ErrorMessage ="UserName Is Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "FirstName Is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName Is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Is Required")]
        [DataType (DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        [Compare (nameof(Password))]
        public string ConfirmPassword { get; set; }

        public bool IsAgree { get; set; }
    }
}
