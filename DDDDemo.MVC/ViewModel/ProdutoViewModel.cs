using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDDDemo.MVC.ViewModel
{
    public class ProdutoViewModel
    {
        [DisplayName("ID")]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Infome o campo {0}.")]
        [StringLength(120, MinimumLength = 3, ErrorMessage = "O campo {0} deve possuir entre 3 e 120 caracteres.")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        //[Range(0,(double) decimal.MaxValue)]
        [Required(ErrorMessage = "Infome o campo {0}.")]
        public decimal Valor { get; set; }

        [DisplayName("Disponivel?")]
        public bool Situacao { get; set; }

        public string SituacaoTexto { get { return Situacao == true ? "Sim" : "Não"; } }

        [DisplayName("Categoria")]
        public int CategoriaId { get; set; }

        public virtual CategoriaViewModel Categoria { get; set; }
    }
}