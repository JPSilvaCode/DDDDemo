using DDDDemo.Aplicacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDDDemo.MVC.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaAppService _categoriaAppService;

        public CategoriaController(ICategoriaAppService categoriaAppService)
        {
            _categoriaAppService = categoriaAppService;
        }

        // GET: Categoria
        public ActionResult Index()
        {
            var categorias = _categoriaAppService.GetAll();
            return View(categorias);
        }
    }
}