using DDDDemo.Dominio.Entidades;
using DomainValidation.Interfaces.Specification;

namespace DDDDemo.Dominio.Specifications.CategoriaSpec
{
    public class CategoriaNomeObrigatorioSpec : ISpecification<Categoria>
    {
        public bool IsSatisfiedBy(Categoria categoria)
        {
            return !string.IsNullOrEmpty(categoria.Nome) && !string.IsNullOrWhiteSpace(categoria.Nome);
        }
    }
}
