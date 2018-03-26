using DDDDemo.Dominio.Interfaces.Validation;
using DDDDemo.Dominio.Validations.CategoriaValid;
using DomainValidation.Validation;
using System.Collections.Generic;

namespace DDDDemo.Dominio.Entidades
{
    public class Categoria : ISelfValidation
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }

        public virtual IEnumerable<Produto> Produtos { get; set; }

        public ValidationResult ValidationResult { get; private set; }

        //public bool IsValid()
        //{           
        //    ValidationResult = new CategoriaConsistenciaValid().Validate(this);
        //    return ValidationResult.IsValid;
        //}

        public bool IsValid
        {
            get
            {
                ValidationResult = new CategoriaConsistenciaValid().Validate(this);
                return ValidationResult.IsValid;
            }
        }
    }
}
