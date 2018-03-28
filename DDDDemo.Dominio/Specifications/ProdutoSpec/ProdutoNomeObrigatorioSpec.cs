using DDDDemo.Dominio.Entidades;
using DomainValidation.Interfaces.Specification;

namespace DDDDemo.Dominio.Specifications.ProdutoSpec
{
    public class ProdutoNomeObrigatorioSpec : ISpecification<Produto>
    {
        public bool IsSatisfiedBy(Produto produto)
        {
            return !string.IsNullOrEmpty(produto.Nome) && !string.IsNullOrWhiteSpace(produto.Nome);
        }
    }
}
