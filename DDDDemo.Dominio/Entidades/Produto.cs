using DDDDemo.Dominio.Interfaces.Validation;
using DDDDemo.Dominio.Validations.ProdutoValid;
using DomainValidation.Validation;

namespace DDDDemo.Dominio.Entidades
{
    public class Produto : ISelfValidation
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Situacao { get; set; }
        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }

        public ValidationResult ValidationResult { get; private set; }

        public bool IsValid
        {
            get
            {
                ValidationResult = new ProdutoConsistenciaValid().Validate(this);
                return ValidationResult.IsValid;
            }
        }
    }
}
