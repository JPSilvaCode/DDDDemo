using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Interfaces.Repositorio;
using DDDDemo.Infraestrutura.Dados.Repository.Repositorio.Base;
using System.Linq;

namespace DDDDemo.Infraestrutura.Dados.Repository.Repositorio
{
    public class CategoriaRepository : RepositoryBase<Categoria>, ICategoriaRepository
    {
        public Categoria BuscarPorNome(string nome)
        {
            return Db.Categorias.FirstOrDefault(p => p.Nome == nome);
        }
    }
}
