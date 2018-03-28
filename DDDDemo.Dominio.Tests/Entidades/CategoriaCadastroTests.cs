using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Interfaces.Repositorio;
using DDDDemo.Dominio.Tests.Utils;
using DDDDemo.Dominio.Validations.CategoriaValid;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDDemo.Dominio.Tests.Entidades
{
    [TestClass]
    public class CategoriaCadastroTests
    {
        [TestMethod]
        public void Categoria_Validation_True()
        {
            var categoria = new Categoria()
            {
                Nome = ""
            };
            
            var stubRepository = MockRepository.GenerateStub<ICategoriaRepository>();
            stubRepository.Stub(s => s.BuscarPorNome(categoria.Nome)).Return(null); // objeto não encontrado - null

            var alunoValidation = new CategoriaCadastroValid(stubRepository);
            Assert.IsTrue(alunoValidation.Validate(categoria).IsValid);
        }

        [TestMethod]
        public void Categoria_Validation_False()
        {
            var categoria = new Categoria()
            {
                Nome = "Papel"
            };

            var stubRepository = MockRepository.GenerateStub<ICategoriaRepository>();
            stubRepository.Stub(s => s.BuscarPorNome(categoria.Nome)).Return(categoria); // objeto encontrado

            var alunoValidation = new CategoriaCadastroValid(stubRepository);
            Assert.IsFalse(alunoValidation.Validate(categoria).IsValid);            
        }
    }
}
