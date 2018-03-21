using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Interfaces.Repositorio;
using DDDDemo.Infraestrutura.Dados.Repository.Repositorio.Base;
using System.Collections.Generic;
using System.Linq;

namespace DDDDemo.Infraestrutura.Dados.Repository.Repositorio
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
