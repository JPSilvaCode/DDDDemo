using DDDDemo.Aplicacao.Base;
using DDDDemo.Aplicacao.Interfaces;
using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDDemo.Aplicacao
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }
    }
}
