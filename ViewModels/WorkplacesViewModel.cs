using HotDesk.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotDesk.ViewModels
{
    public class WorkplacesViewModel
    {
        public IEnumerable<Workplace> Workplaces { get; set; }

        [Required(ErrorMessage = "Введите описание")]
        public string Description { get; set; }
        public bool HasDesktop { get; set; }
    }
}
