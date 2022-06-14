using System.ComponentModel.DataAnnotations;

namespace BlogSystem.ViewModels.Admin
{
    public class LoginViewModel:PassBaseViewModel
    {
        [Required(ErrorMessage = "密码是必填项。")]
        [DataType(DataType.Password)]
        [Display(Name = "密码:")]
        public string Password { get; set; }
    }
}
