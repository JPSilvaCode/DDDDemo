using DDDDemo.Dominio.Interfaces.Repositorio;
using DDDDemo.Dominio.Interfaces.Repositorio.Base;
using DDDDemo.Infraestrutura.Dados.Repository.Repositorio;
using DDDDemo.Infraestrutura.Dados.Repository.Repositorio.Base;
using Ninject.Modules;

namespace DDDDemo.Infraestrutura.CrossCutting.IoC.Modulos
{
    public class RepositoryNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<ICategoriaRepository>().To<CategoriaRepository>();
            Bind<IProdutoRepository>().To<ProdutoRepository>();
        }
    }
}
