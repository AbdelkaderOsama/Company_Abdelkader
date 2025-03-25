using System.ComponentModel.DataAnnotations;

namespace Company_Abdelkader.PL.Dtos
{
    public class SignInDto
    {
        [Required(ErrorMessage = "Email Is Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
