using DDDDemo.Aplicacao.Base;
using DDDDemo.Aplicacao.Interfaces;
using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Interfaces.Servico;
using DDDDemo.Infraestrutura.Dados.Contexto.UOW.Interface;

namespace DDDDemo.Aplicacao
{
    public class CategoriaAppService : AppServiceBase<Categoria>, ICategoriaAppService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICategoriaService _categoriaService;

        public CategoriaAppService(IUnitOfWork unitOfWork, ICategoriaService categoriaService)
           : base(unitOfWork,categoriaService)
        {
            _unitOfWork = unitOfWork;
            _categoriaService = categoriaService;
        }
    }
}
