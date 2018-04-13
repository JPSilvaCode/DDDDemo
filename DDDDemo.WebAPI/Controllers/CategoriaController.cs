using DDDDemo.Aplicacao.Interfaces;
using DDDDemo.Dominio.Entidades;
using DDDDemo.WebAPI.Utils;
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

        // GET api/Categoria/
        public IEnumerable<Categoria> GetCategorias()
        {
            return _categoriaAppService.GetAll().AsEnumerable();
        }

        // GET api/Categoria/id
        public Categoria GetCategoria(int id)
        {
            var categoria = _categoriaAppService.GetById(id);
            if (categoria == null)
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, String.Format("Nenhum resultado encontrado para a busca do ID {0}.", id)));

            return _categoriaAppService.GetById(id);
        }

        // POST api/Categoria/
        [HttpPost]
        public HttpResponseMessage PostCategoria(Categoria categoria)
        {            
            var validationResult = _categoriaAppService.Add(categoria);

            if (validationResult.IsValid)
                return Request.CreateResponse(HttpStatusCode.OK, "Cadastro realizado com sucesso!");

            string erros = "";
            foreach (var error in validationResult.Erros)
            {
                var extract = new ValidationMessageExtract(error.Message);
                erros += (string.IsNullOrEmpty(erros) ? "" : " ") + (string.IsNullOrEmpty(extract.SeparateField()) ? extract.SeparateMessage() : string.Format("Campo {0}: {1}", extract.SeparateField(), extract.SeparateMessage()));
            }

            var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
            {
                StatusCode = HttpStatusCode.InternalServerError,
                Content = new StringContent(erros),
                ReasonPhrase = "Validação de cadastro inválida"
            };
            throw new HttpResponseException(resp);
        }
    }
}
