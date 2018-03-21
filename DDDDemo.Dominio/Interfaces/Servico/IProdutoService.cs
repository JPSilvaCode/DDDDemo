using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Interfaces.Servico.Base;
using System.Collections.Generic;

namespace DDDDemo.Dominio.Interfaces.Servico
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
