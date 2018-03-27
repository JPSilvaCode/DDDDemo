using AutoMapper;
using DDDDemo.Aplicacao.Interfaces;
using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Tests.Utils;
using DDDDemo.MVC.ViewModel;
using PagedList;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult Index(int? pagina)
        {           
            var categoriaViewModel = Mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaViewModel>>(_categoriaAppService.GetAll());

            //PagedList
            int paginaTamanho = 10;
            int paginaNumero = (pagina ?? 1);            
            categoriaViewModel = categoriaViewModel.OrderBy(c => c.CategoriaId).ToPagedList(paginaNumero, paginaTamanho);

            return View(categoriaViewModel);
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(_categoriaAppService.GetById(id));

            return View(categoriaViewModel);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriaViewModel categoriaViewModel)
        {
            if (ModelState.IsValid)
            {
                var categoria = Mapper.Map<CategoriaViewModel, Categoria>(categoriaViewModel);

                var validationResult = _categoriaAppService.Add(categoria);

                if (validationResult.IsValid)
                    return RedirectToAction("Index");

                foreach (var error in validationResult.Erros)
                {
                    var extract = new ValidationMessageExtract(error.Message);
                    ModelState.AddModelError(extract.SeparateField(), extract.SeparateMessage());
                }                    
            }

            return View(categoriaViewModel);
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(_categoriaAppService.GetById(id));

            return View(categoriaViewModel);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriaViewModel categoriaViewModel)
        {
            if (ModelState.IsValid)
            {
                var categoria = Mapper.Map<CategoriaViewModel, Categoria>(categoriaViewModel);

                var validationResult = _categoriaAppService.Update(categoria);

                if (validationResult.IsValid)
                    return RedirectToAction("Index");

                foreach (var error in validationResult.Erros)
                {
                    var extract = new ValidationMessageExtract(error.Message);
                    ModelState.AddModelError(extract.SeparateField(), extract.SeparateMessage());
                }
            }

            return View(categoriaViewModel);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(_categoriaAppService.GetById(id));

            return View(categoriaViewModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var categoria = _categoriaAppService.GetById(id);
            _categoriaAppService.Remove(categoria);

            return RedirectToAction("Index");
        }
    }
}