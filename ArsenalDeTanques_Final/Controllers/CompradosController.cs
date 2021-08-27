using ArsenalDeTanques.Models;
using ArsenalDeTanques.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalDeTanques.Controllers
{
    [Authorize]
    public class CompradosController : Controller
    {
        ComprasService service;
        ICrudService tankService;
        public CompradosController(ComprasService service, ICrudService tankService)
        {
            this.service = service;
            this.tankService = tankService;
        }

        public IActionResult Index(string busca = null, bool ord = false, string operacao = null)
        {
            ViewBag.ordenar = ord;
            var compras = service.GetAll(User.Identity.Name, busca, ord);
            ViewBag.investido = service.investiu(compras);
            ViewBag.operacaoRealizada = "";
            return View(compras);
        }

        public IActionResult ReadSingle(int id)
        {
            return View(service.Get(id));
        }

        public IActionResult Criar(int id)
        {
            return View(tankService.Get(id));
        }

        public IActionResult ConfirmarCriar(int id)
        {
            var tanque = tankService.Get(id);
            if (tanque != null ? service.Comprar(tanque, User.Identity.Name) : false)
            {
                ViewBag.operacaoRealizada = "create";
                ViewBag.ordenar = false;
                var compras = service.GetAll(User.Identity.Name);
                ViewBag.investido = service.investiu(compras);
                return View("Index", compras);
            }
            else return View("Criar",tanque);
        }

        [HttpGet]
        public IActionResult Update(int id, string servico = "sql")
        {
            Compra compra = service.Get(id);
            var tanques = tankService.GetAll();
            ViewBag.Tanques = new SelectList(tanques, "Id", "Nome", compra.tanque);
            return View(compra);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Compra compraEditada)
        {
            var tanques = tankService.GetAll();
            var compras = service.GetAll(User.Identity.Name);
            ViewBag.compras = new SelectList(tanques, "Id", "Nome", compraEditada.tanque);
            if (!ModelState.IsValid) return View(compraEditada);
            if (service.Update(compraEditada,User.Identity.Name))
            {
                ViewBag.operacaoRealizada = "update";
                ViewBag.ordenar = false;
                ViewBag.investido = service.investiu(compras);
                return View("Index", compras);
            }
            else return View(compraEditada);
        }

        public IActionResult Delete(int id)
        {
            return View(service.Get(id));
        }

        public IActionResult ConfirmarDelete(int id)
        {
            
            ViewBag.operacaoRealizada = "delete";
            ViewBag.ordenar = false;

            if (service.Delete(id)) {
                var compras = service.GetAll(User.Identity.Name);
                ViewBag.investido = service.investiu(compras);
                return View("Index", compras); 
            }
            else throw new Exception();
        }
    }
}
