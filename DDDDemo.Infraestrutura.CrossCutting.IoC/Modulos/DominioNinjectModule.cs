using DDDDemo.Dominio.Interfaces.Servico;
using DDDDemo.Dominio.Interfaces.Servico.Base;
using DDDDemo.Dominio.Servicos;
using DDDDemo.Dominio.Servicos.Base;
using Ninject.Modules;

namespace DDDDemo.Infraestrutura.CrossCutting.IoC.Modulos
{
    public class DominioNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<ICategoriaService>().To<CategoriaService>();
            Bind<IProdutoService>().To<ProdutoService>();
        }
    }
}
