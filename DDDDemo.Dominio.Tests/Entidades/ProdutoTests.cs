using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Tests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DDDDemo.Dominio.Tests.Entidades
{
    [TestClass]
    public class ProdutoTests
    {
        [TestMethod]
        public void Produto_Consistente_True()
        {
            var produto = new Produto()
            {
                Nome = "Paple Higienico", //informando Nome Válido 
                Valor = 10, //informando Valor Válido 
                Situacao = true,
                CategoriaId = 1, //informando CategoriaId Válida
            };

            Assert.IsTrue(produto.IsValid);
        }

        [TestMethod]
        public void Produto_Consistente_False()
        {
            var produto = new Produto()
            {
                Nome = "", //informando Nome Inválido 
                Valor = 0, //informando Valor Inválido 
                Situacao = true,
                CategoriaId = 0, //informando CategoriaId Inválida
            };

            Assert.IsFalse(produto.IsValid);
            Assert.IsTrue(produto.ValidationResult.Erros.Any(e => new ValidationMessageExtract(e.Message).SeparateMessage() == "O Nome é obrigatório"));
            Assert.IsTrue(produto.ValidationResult.Erros.Any(e => new ValidationMessageExtract(e.Message).SeparateMessage() == "O Nome é muito pequeno"));
            Assert.IsTrue(produto.ValidationResult.Erros.Any(e => new ValidationMessageExtract(e.Message).SeparateMessage() == "O Nome é muito grande"));
            Assert.IsTrue(produto.ValidationResult.Erros.Any(e => new ValidationMessageExtract(e.Message).SeparateMessage() == "O Valor deve ser maior que zero"));
            Assert.IsTrue(produto.ValidationResult.Erros.Any(e => new ValidationMessageExtract(e.Message).SeparateMessage() == "A categoria é obrigatória"));
        }
    }
}
