using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Interfaces.Repositorio;
using DDDDemo.Infraestrutura.Dados.Repository.Repositorio.Base;

namespace DDDDemo.Infraestrutura.Dados.Repository.Repositorio
{
    public class CategoriaRepository : RepositoryBase<Categoria>, ICategoriaRepository
    {
    }
}
