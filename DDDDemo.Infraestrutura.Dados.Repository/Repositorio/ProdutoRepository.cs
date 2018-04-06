using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Interfaces.Repositorio;
using DDDDemo.Infraestrutura.Dados.Contexto.Contexto;
using DDDDemo.Infraestrutura.Dados.Repository.Repositorio.Base;
using System.Collections.Generic;
using System.Linq;

namespace DDDDemo.Infraestrutura.Dados.Repository.Repositorio
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public ProdutoRepository(DDDDemoContext context)
          : base(context)
        {

        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _dbset.Where(p => p.Nome == nome);
        }
    }
}
