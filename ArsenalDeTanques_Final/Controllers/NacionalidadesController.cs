using ArsenalDeTanques.Models;
using ArsenalDeTanques.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ArsenalDeTanques.Controllers
{
    public class NacionalidadesController : Controller
    {
        NacionalidadeService _service;
        public NacionalidadesController(NacionalidadeService service)
        {
            _service = service;
        }
        public IActionResult Index(string busca, bool ord = false)
        {
            ViewBag.operacaoRealizada = "";
            ViewBag.ordenar = ord;
            return View(_service.GetAll(busca,ord));
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Nacionalidade nacionalidadeCriada)
        {
            if (!ModelState.IsValid) return View(nacionalidadeCriada);

            ViewBag.operacaoRealizada = "create";
            ViewBag.ordenar = false;

            return _service.Create(nacionalidadeCriada) ? View("Index",_service.GetAll()) : View(nacionalidadeCriada);
        }

        public IActionResult ReadSingle(int id)
        {
            return View(_service.Get(id));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_service.Get(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Nacionalidade nacionalidadeEditada)
        {
            if (!ModelState.IsValid) return View(nacionalidadeEditada);

            ViewBag.operacaoRealizada = "update";
            ViewBag.ordenar = false;

            return _service.Update(nacionalidadeEditada) ? View("Index", _service.GetAll()) : View(nacionalidadeEditada);
        }

        public IActionResult Delete(int id)
        {
            return View(_service.Get(id));
        }

        public IActionResult ConfirmarDelete(int id)
        {
            ViewBag.operacaoRealizada = "delete";
            ViewBag.ordenar = false;

            if (_service.Delete(id)) return View("Index", _service.GetAll());
            else throw new Exception();
        }
    }
}
