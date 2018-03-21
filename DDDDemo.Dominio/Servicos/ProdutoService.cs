using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Interfaces.Repositorio;
using DDDDemo.Dominio.Interfaces.Servico;
using DDDDemo.Dominio.Servicos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDDemo.Dominio.Servicos
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
             : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
    }
}
