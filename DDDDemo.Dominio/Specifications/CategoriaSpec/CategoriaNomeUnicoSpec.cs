using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Interfaces.Repositorio;
using DomainValidation.Interfaces.Specification;

namespace DDDDemo.Dominio.Specifications.CategoriaSpec
{
    public class CategoriaNomeUnicoSpec : ISpecification<Categoria>
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaNomeUnicoSpec(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public bool IsSatisfiedBy(Categoria categoria)
        {
            return _categoriaRepository.BuscarPorNome(categoria.Nome) == null;
        }
    }
}
