using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Specifications.CategoriaSpec;
using DomainValidation.Validation;

namespace DDDDemo.Dominio.Validations.CategoriaValid
{
    public class CategoriaConsistenciaValid : Validator<Categoria>
    {
        public CategoriaConsistenciaValid()
        {           
            base.Add("NomeCategoria", new Rule<Categoria>(new CategoriaNomeObrigatorioSpec(), ValidationMessages.NomeIsRequired));
        }
    }
}
