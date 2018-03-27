using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Tests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DDDDemo.Dominio.Tests.Entidades
{
    [TestClass]
    public class CategoriaTests
    {
        [TestMethod]
        public void Categoria_Consistente_True()
        {
            var categoria = new Categoria()
            {
                Nome = "Pap", //informando Nome Válido               
            };

            Assert.IsTrue(categoria.IsValid);
        }

        [TestMethod]
        public void Aluno_Consistente_False()
        {
            var categoria = new Categoria()
            {
                Nome = "", //informando Nome Inválido               
            };

            Assert.IsFalse(categoria.IsValid);
            Assert.IsTrue(categoria.ValidationResult.Erros.Any(e => new ValidationMessageExtract(e.Message).SeparateMessage() == "O Nome é obrigatório"));
            Assert.IsTrue(categoria.ValidationResult.Erros.Any(e => new ValidationMessageExtract(e.Message).SeparateMessage() == "O Nome é muito pequeno"));
            Assert.IsTrue(categoria.ValidationResult.Erros.Any(e => new ValidationMessageExtract(e.Message).SeparateMessage() == "O Nome é muito grande"));
        }
    }
}
