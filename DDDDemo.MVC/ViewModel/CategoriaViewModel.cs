using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDDDemo.MVC.ViewModel
{
    public class CategoriaViewModel
    {
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Infome o campo Nome.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo observação deve ter entre 5 e 50 caracteres.")]
        public string Nome { get; set; }
    }
}