using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Specifications.CategoriaSpec;
using DomainValidation.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDDemo.Dominio.Validations.CategoriaValid
{
    public class CategoriaConsistenciaValid : Validator<Categoria>
    {
        public CategoriaConsistenciaValid()
        {
            base.Add("Testando", new Rule<Categoria>(new CategoriaNomeObrigatorioSpec(), ValidationMessages.NomeIsRequired));
        }
    }
}
