using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Interfaces.Repositorio.Base;
using System.Collections.Generic;

namespace DDDDemo.Dominio.Interfaces.Repositorio
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
