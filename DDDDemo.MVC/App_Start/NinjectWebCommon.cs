using DDDDemo.Aplicacao;
using DDDDemo.Aplicacao.Base;
using DDDDemo.Aplicacao.Interfaces;
using DDDDemo.Aplicacao.Interfaces.Base;
using DDDDemo.Dominio.Interfaces.Repositorio;
using DDDDemo.Dominio.Interfaces.Repositorio.Base;
using DDDDemo.Dominio.Interfaces.Servico;
using DDDDemo.Dominio.Interfaces.Servico.Base;
using DDDDemo.Dominio.Servicos;
using DDDDemo.Dominio.Servicos.Base;
using DDDDemo.Infraestrutura.Dados.Repository.Repositorio;
using DDDDemo.Infraestrutura.Dados.Repository.Repositorio.Base;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using System;
using System.Web;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(DDDDemo.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(DDDDemo.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace DDDDemo.MVC.App_Start
{
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch (Exception)
            {
                kernel.Dispose();
                throw;
            }

        }
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<ICategoriaAppService>().To<CategoriaAppService>();
            kernel.Bind<IProdutoAppService>().To<ProdutoAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<ICategoriaService>().To<CategoriaService>();
            kernel.Bind<IProdutoService>().To<ProdutoService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<ICategoriaRepository>().To<CategoriaRepository>();
            kernel.Bind<IProdutoRepository>().To<ProdutoRepository>();
        }
    }
}