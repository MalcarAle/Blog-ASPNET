using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Accounts
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "O Email é obrigatório!")]
        [EmailAddress(ErrorMessage = "O Email é inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Senha não foi inserida!")]
        public string Password { get; set; }

    }
}
