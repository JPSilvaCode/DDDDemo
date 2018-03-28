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

        public string Nome { get; set; }

        //[DataType(DataType.Currency)]
        public decimal Valor { get; set; }

        [DisplayName("Disponivel?")]
        public bool Situacao { get; set; }

        public string SituacaoTexto { get { return Situacao == true ? "Sim" : "Não"; } }

        [DisplayName("Categoria")]
        public int CategoriaId { get; set; }

        public virtual CategoriaViewModel Categoria { get; set; }
    }
}