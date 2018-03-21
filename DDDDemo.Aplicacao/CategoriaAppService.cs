using DDDDemo.Aplicacao.Base;
using DDDDemo.Aplicacao.Interfaces;
using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Interfaces.Servico;

namespace DDDDemo.Aplicacao
{
    public class CategoriaAppService : AppServiceBase<Categoria>, ICategoriaAppService
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaAppService(ICategoriaService categoriaService)
           : base(categoriaService)
        {
            _categoriaService = categoriaService;
        }
    }
}
