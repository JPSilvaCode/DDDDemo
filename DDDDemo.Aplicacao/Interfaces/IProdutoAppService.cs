using DDDDemo.Aplicacao.Interfaces.Base;
using DDDDemo.Dominio.Entidades;
using System.Collections.Generic;

namespace DDDDemo.Aplicacao.Interfaces
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
