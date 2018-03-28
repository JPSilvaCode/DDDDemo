using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Interfaces.Repositorio;
using DDDDemo.Dominio.Specifications.CategoriaSpec;
using DomainValidation.Validation;

namespace DDDDemo.Dominio.Validations.CategoriaValid
{
    public class CategoriaCadastroValid :  Validator<Categoria>
    {
        public CategoriaCadastroValid(ICategoriaRepository categoriaRepository)            
        {
            base.Add("CategoriaUnica", new Rule<Categoria>(new CategoriaNomeUnicoSpec(categoriaRepository), ValidationMessages.cadastroAlready));
        }
    }
}
