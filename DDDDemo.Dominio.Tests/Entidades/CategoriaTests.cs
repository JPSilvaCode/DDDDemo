using DDDDemo.Dominio.Entidades;
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
                Nome = "João Paulo", //informando Nome Válido               
            };

            Assert.IsTrue(categoria.IsValid());
        }

        [TestMethod]
        public void Aluno_Consistente_False()
        {
            var categoria = new Categoria()
            {
                Nome = "", //informando Nome Inválido               
            };

            Assert.IsFalse(categoria.IsValid());
            Assert.IsTrue(categoria.ValidationResult.Erros.Any(e => e.Message == "O Nome é obrigatório"));
        }
    }
}
