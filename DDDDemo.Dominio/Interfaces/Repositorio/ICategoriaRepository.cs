using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Interfaces.Repositorio.Base;

namespace DDDDemo.Dominio.Interfaces.Repositorio
{
    public interface ICategoriaRepository : IRepositoryBase<Categoria>
    {
        Categoria BuscarPorNome(string nome);
    }
}
