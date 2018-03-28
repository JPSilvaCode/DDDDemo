using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDDDemo.MVC.ViewModel
{
    public class CategoriaViewModel
    {
        [DisplayName("ID")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Infome o campo {0}.")]
        [StringLength(120, MinimumLength = 3, ErrorMessage = "O campo {0} deve possuir entre 3 e 120 caracteres.")]
        public string Nome { get; set; }
    }
}