using DDDDemo.Aplicacao.Interfaces;
using DDDDemo.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DDDDemo.WebAPI.Controllers
{
    public class CategoriaController : ApiController
    {
        private readonly ICategoriaAppService _categoriaAppService;

        public CategoriaController(ICategoriaAppService categoriaAppService)
        {
            _categoriaAppService = categoriaAppService;
        }

        // GET api/Categoria
        public IEnumerable<Categoria> GetCategorias()
        {
            return _categoriaAppService.GetAll().AsEnumerable();
        }
    }
}
