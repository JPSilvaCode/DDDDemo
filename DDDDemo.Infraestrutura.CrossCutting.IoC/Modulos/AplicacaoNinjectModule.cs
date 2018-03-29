using DDDDemo.Aplicacao;
using DDDDemo.Aplicacao.Base;
using DDDDemo.Aplicacao.Interfaces;
using DDDDemo.Aplicacao.Interfaces.Base;
using Ninject.Modules;

namespace DDDDemo.Infraestrutura.CrossCutting.IoC.Modulos
{
    public class AplicacaoNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            Bind<ICategoriaAppService>().To<CategoriaAppService>();
            Bind<IProdutoAppService>().To<ProdutoAppService>();
        }
    }
}
