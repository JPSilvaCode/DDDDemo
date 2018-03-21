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
    public class CategoriaService : ServiceBase<Categoria> , ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
             : base(categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
    }
}
