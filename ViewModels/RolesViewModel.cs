using HotDesk.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotDesk.ViewModels
{
    public class RolesViewModel
    {
        public IEnumerable<Role> Roles { get; set; }

        [Required(ErrorMessage = "Роль не может быть пустой")]
        public string RoleName { get; set; }
    }
}
