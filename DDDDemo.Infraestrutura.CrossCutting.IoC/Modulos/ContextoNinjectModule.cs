using DDDDemo.Infraestrutura.Dados.Contexto.Contexto;
using DDDDemo.Infraestrutura.Dados.Contexto.UOW;
using DDDDemo.Infraestrutura.Dados.Contexto.UOW.Interface;
using Ninject.Modules;
using Ninject.Web.Common;

namespace DDDDemo.Infraestrutura.CrossCutting.IoC.Modulos
{
    public class ContextoNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<DDDDemoContext>().ToSelf().InRequestScope();
            Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
