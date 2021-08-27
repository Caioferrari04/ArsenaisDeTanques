using ArsenalDeTanques.Models;
using ArsenalDeTanques.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalDeTanques.Controllers
{
    public class TanquesController : Controller
    {
        ITanquesStatic service;
        ITanquesMisc service_misc;
        public TanquesController(ITanquesStatic service, ITanquesMisc service_misc)
        {
            this.service = service;
            this.service_misc = service_misc;
        }

        public IActionResult Index(string busca)
        {
            ViewBag.itemCriado = false;
            ViewBag.itemAtualizado = false;
            ViewBag.itemDeletado = false;
            ViewBag.ordenar = false;
            ViewBag.totalTripulacao = service_misc.totalTripulacao(service.GetAll());
            ViewBag.tanqueRecente = service_misc.tanqueRecente(service.GetAll());
            ViewBag.maiorMotor = service_misc.maiorMotor(service.GetAll());
            return View(service.GetAll(busca));
        }

        [HttpPost]
        public IActionResult Index(int? nada)
        {
            ViewBag.itemCriado = false;
            ViewBag.itemAtualizado = false;
            ViewBag.itemDeletado = false;
            ViewBag.ordenar = true;
            ViewBag.totalTripulacao = service_misc.totalTripulacao(service.GetAll());
            ViewBag.tanqueRecente = service_misc.tanqueRecente(service.GetAll());
            ViewBag.maiorMotor = service_misc.maiorMotor(service.GetAll());
            return View(service.GetAll(null,true));
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            return View(service.Get(id));
        }

        public IActionResult ConfirmarDelete(int id)
        {
            ViewBag.itemCriado = false;
            ViewBag.itemAtualizado = false;
            ViewBag.itemDeletado = true;
            ViewBag.ordenar = false;
            ViewBag.totalTripulacao = service_misc.totalTripulacao(service.GetAll());
            ViewBag.tanqueRecente = service_misc.tanqueRecente(service.GetAll());
            ViewBag.maiorMotor = service_misc.maiorMotor(service.GetAll());
            return View("Index", service.Delete(id));
        }
    }
}
