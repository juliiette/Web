using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
    public class UserLoginModel
    {
        [Required] 
        [EmailAddress] 
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Am I ?")] 
        public bool RememberMe { get; set; }
    }
}