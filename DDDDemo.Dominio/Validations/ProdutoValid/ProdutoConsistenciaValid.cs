using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Specifications.ProdutoSpec;
using DomainValidation.Validation;

namespace DDDDemo.Dominio.Validations.ProdutoValid
{
    public class ProdutoConsistenciaValid : Validator<Produto>
    {
        public ProdutoConsistenciaValid()
        {
            base.Add("NomeObrigatorioProduto", new Rule<Produto>(new ProdutoNomeObrigatorioSpec(), ValidationMessages.nomeIsRequired));
            base.Add("NomeMinimoProduto", new Rule<Produto>(new ProdutoNomeMinimoSpec(), ValidationMessages.nomeIsShort));
            base.Add("NomeMaximoProduto", new Rule<Produto>(new ProdutoNomeMaximoSpec(), ValidationMessages.nomeIsLong));
            base.Add("ValorMaior0Produto", new Rule<Produto>(new ProdutoValorMaiorZeroSpec(), ValidationMessages.ValorIsLowerZero));
            base.Add("CategoriaObrigatorioProduto", new Rule<Produto>(new ProdutoCategoriaObrigatorioSpec(), "CategoriaId|A categoria é obrigatória"));
        }
    }
}
