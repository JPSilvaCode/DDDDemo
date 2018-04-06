using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Interfaces.Repositorio;
using DDDDemo.Infraestrutura.Dados.Contexto.Contexto;
using DDDDemo.Infraestrutura.Dados.Repository.Repositorio.Base;
using System.Linq;

namespace DDDDemo.Infraestrutura.Dados.Repository.Repositorio
{
    public class CategoriaRepository : RepositoryBase<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(DDDDemoContext context)
           : base(context)
        {

        }

        public Categoria BuscarPorNome(string nome)
        {
            return _dbset.FirstOrDefault(p => p.Nome == nome);
        }
    }
}
