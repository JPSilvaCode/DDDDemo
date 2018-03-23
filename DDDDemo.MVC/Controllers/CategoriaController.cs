﻿using DDDDemo.Aplicacao.Interfaces;
using DDDDemo.Dominio.Entidades;
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

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            var categoria = _categoriaAppService.GetById(id);            

            return View(categoria);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria categoria)
        {
            if (ModelState.IsValid)
            {               
                _categoriaAppService.Add(categoria);

                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            var categoria = _categoriaAppService.GetById(id);            

            return View(categoria);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _categoriaAppService.Update(categoria);

                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var categoria = _categoriaAppService.GetById(id);            

            return View(categoria);
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