using DDDDemo.Dominio.Entidades;
using DomainValidation.Interfaces.Specification;
using System;

namespace DDDDemo.Dominio.Specifications.CategoriaSpec
{
    public class CategoriaNomeMaximoSpec : ISpecification<Categoria>
    {
        public bool IsSatisfiedBy(Categoria categoria)
        {
            return !string.IsNullOrEmpty(categoria.Nome) && !string.IsNullOrWhiteSpace(categoria.Nome) && categoria.Nome.ToString().Trim().Length < 121;
        }
    }
}
