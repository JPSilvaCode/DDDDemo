using AutoMapper;
using DDDDemo.Aplicacao.Interfaces;
using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Tests.Utils;
using DDDDemo.MVC.ViewModel;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDDDemo.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoAppService _produtoAppService;
        private readonly ICategoriaAppService _categoriaAppService;

        public ProdutoController(IProdutoAppService produtoAppService, ICategoriaAppService categoriaAppService)
        {
            _produtoAppService = produtoAppService;
            _categoriaAppService = categoriaAppService;
        }

        // GET: Produto
        public ActionResult Index(int? pagina)
        {
            var produtoViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoAppService.GetAll());

            //PagedList
            int paginaTamanho = 10;
            int paginaNumero = (pagina ?? 1);
            produtoViewModel = produtoViewModel.OrderBy(c => c.CategoriaId).ToPagedList(paginaNumero, paginaTamanho);

            return View(produtoViewModel);
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(_produtoAppService.GetById(id));

            return View(produtoViewModel);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            ViewBag.CategoriaId = new SelectList(_categoriaAppService.GetAll(), "CategoriaId", "Nome");
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                var produto = Mapper.Map<ProdutoViewModel, Produto>(produtoViewModel);

                var validationResult = _produtoAppService.Add(produto);

                if (validationResult.IsValid)
                    return RedirectToAction("Index");

                foreach (var error in validationResult.Erros)
                {
                    var extract = new ValidationMessageExtract(error.Message);
                    ModelState.AddModelError(extract.SeparateField(), extract.SeparateMessage());
                }
            }

            ViewBag.CategoriaId = new SelectList(_categoriaAppService.GetAll(), "CategoriaId", "Nome", produtoViewModel.CategoriaId);
            return View(produtoViewModel);
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(_produtoAppService.GetById(id));

            ViewBag.CategoriaId = new SelectList(_categoriaAppService.GetAll(), "CategoriaId", "Nome", produtoViewModel.CategoriaId);
            return View(produtoViewModel);
        }

        // POST: Produto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                var produto = Mapper.Map<ProdutoViewModel, Produto>(produtoViewModel);

                var validationResult = _produtoAppService.Update(produto);

                if (validationResult.IsValid)
                    return RedirectToAction("Index");

                foreach (var error in validationResult.Erros)
                {
                    var extract = new ValidationMessageExtract(error.Message);
                    ModelState.AddModelError(extract.SeparateField(), extract.SeparateMessage());
                }
            }

            ViewBag.CategoriaId = new SelectList(_categoriaAppService.GetAll(), "CategoriaId", "Nome", produtoViewModel.CategoriaId);
            return View(produtoViewModel);
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(_produtoAppService.GetById(id));

            return View(produtoViewModel);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var produto = _produtoAppService.GetById(id);
            _produtoAppService.Remove(produto);

            return RedirectToAction("Index");
        }
    }
}