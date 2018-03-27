using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Specifications.CategoriaSpec;
using DomainValidation.Validation;

namespace DDDDemo.Dominio.Validations.CategoriaValid
{
    public class CategoriaConsistenciaValid : Validator<Categoria>
    {
        public CategoriaConsistenciaValid()
        {           
            base.Add("NomeObrigatorioCategoria", new Rule<Categoria>(new CategoriaNomeObrigatorioSpec(), ValidationMessages.nomeIsRequired));
            base.Add("NomeMinimoCategoria", new Rule<Categoria>(new CategoriaNomeMinimoSpec(), ValidationMessages.nomeIsShort));
            base.Add("NomeMaximoCategoria", new Rule<Categoria>(new CategoriaNomeMaximoSpec(), ValidationMessages.nomeIsLong));
        }
    }
}
