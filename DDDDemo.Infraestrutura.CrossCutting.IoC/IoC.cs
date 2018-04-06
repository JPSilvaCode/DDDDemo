using CommonServiceLocator.NinjectAdapter.Unofficial;
using DDDDemo.Infraestrutura.CrossCutting.IoC.Modulos;
using Ninject;
using Microsoft.Practices.ServiceLocation;
using System;

namespace DDDDemo.Infraestrutura.CrossCutting.IoC
{
    public class IoC
    {
        public IKernel Kernel { get; private set; }

        public IoC()
        {
            Kernel = GetNinjectModules();
            ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(Kernel));
        }

        private IKernel GetNinjectModules()
        {
            return new StandardKernel(
                new DominioNinjectModule(),
                new RepositoryNinjectModule(),
                new AplicacaoNinjectModule(),
                new ContextoNinjectModule());
        }
    }
}
