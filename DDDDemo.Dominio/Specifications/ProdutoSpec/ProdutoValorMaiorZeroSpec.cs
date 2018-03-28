using DDDDemo.Dominio.Entidades;
using DomainValidation.Interfaces.Specification;

namespace DDDDemo.Dominio.Specifications.ProdutoSpec
{
    class ProdutoValorMaiorZeroSpec : ISpecification<Produto>
    {
        public bool IsSatisfiedBy(Produto produto)
        {
            return produto.Valor > 0;
        }
    }
}
