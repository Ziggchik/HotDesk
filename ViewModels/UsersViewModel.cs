using HotDesk.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotDesk.ViewModels
{
    public class UsersViewModel
    {
        public IEnumerable<User> Users { get; set; }

        [Required(ErrorMessage = "Введите логин")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Придумайте пароль")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Выберите роль")]
        public int RoleId { get; set; }
    }
}