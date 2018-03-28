using DDDDemo.Dominio.Entidades;
using DomainValidation.Interfaces.Specification;
using System;

namespace DDDDemo.Dominio.Specifications.ProdutoSpec
{
    public class ProdutoCategoriaObrigatorioSpec : ISpecification<Produto>
    {
        public bool IsSatisfiedBy(Produto produto)
        {
            return produto.CategoriaId > 0;
        }
    }
}
