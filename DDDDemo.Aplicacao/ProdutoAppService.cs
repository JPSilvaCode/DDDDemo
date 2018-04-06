using DDDDemo.Aplicacao.Base;
using DDDDemo.Aplicacao.Interfaces;
using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Interfaces.Servico;
using DDDDemo.Infraestrutura.Dados.Contexto.UOW.Interface;
using System.Collections.Generic;

namespace DDDDemo.Aplicacao
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IUnitOfWork unitOfWork, IProdutoService produtoService)
            : base(unitOfWork, produtoService)
        {
            _unitOfWork = unitOfWork;
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }
    }
}
