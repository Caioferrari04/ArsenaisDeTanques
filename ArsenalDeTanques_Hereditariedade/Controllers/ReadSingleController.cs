using ArsenalDeTanques.Models;
using ArsenalDeTanques.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalDeTanques.Controllers
{
    public class ReadSingleController : Controller
    {
        ITanquesStatic service;
        ITanquesMisc service_misc;
        public ReadSingleController(ITanquesStatic service, ITanquesMisc service_misc)
        {
            this.service = service;
            this.service_misc = service_misc;
        }

        public IActionResult LerUm(int id) 
        {
            ViewBag.itemAtualizado = false;
            ViewBag.itemCriado = false;
            return Index(service.Get(id)); 
        }

        public IActionResult UpdateOne(int id)
        {
            return Update(service.Get(id));
        }

        public IActionResult Index(TanqueLeve tanque)
        {
            //ViewBag.tanque = tanque;
            return View("Index", tanque);
        }
        public IActionResult Index(TanqueMedio tanque)
        {
            //ViewBag.tanque = tanque;
            return View("Index2", tanque);
        }
        public IActionResult Index(TanquePesado tanque)
        {
            //ViewBag.tanque = tanque;
            return View("Index3",tanque);
        }
        public IActionResult Index(CacaTanque tanque)
        {
            //ViewBag.tanque = tanque;
            return View("Index4",tanque);
        }
        public IActionResult Index(TanqueAnfibio tanque)
        {
            //ViewBag.tanque = tanque;
            return View("Index5",tanque);
        }


        public IActionResult Update(TanqueLeve tanque)
        {
            return View("Update",tanque);
        }


        public IActionResult Update(TanqueMedio tanque)
        {
            return View("Update2", tanque);
        }


        public IActionResult Update(TanquePesado tanque)
        {
            return View("Update3", tanque);
        }

        public IActionResult Update(CacaTanque tanque)
        {
            return View("Update4", tanque);
        }

        public IActionResult Update(TanqueAnfibio tanque)
        {
            return View("Update5", tanque);
        }

        [HttpPost]
        public IActionResult UpdateLeve(TanqueLeve tanqueEditado)
        {
            ViewBag.itemAtualizado = true;
            ViewBag.itemCriado = false;
            return Index(service.UpdateOne(tanqueEditado));
        }
        [HttpPost]
        public IActionResult UpdateMedio(TanqueMedio tanqueEditado)
        {
            ViewBag.itemAtualizado = true;
            ViewBag.itemCriado = false;
            return Index(service.UpdateOne(tanqueEditado));
        }
        [HttpPost]
        public IActionResult UpdatePesado(TanquePesado tanqueEditado)
        {
            ViewBag.itemAtualizado = true;
            ViewBag.itemCriado = false;
            return Index(service.UpdateOne(tanqueEditado));
        }
        [HttpPost]
        public IActionResult UpdateCaca(CacaTanque tanqueEditado)
        {
            ViewBag.itemAtualizado = true;
            ViewBag.itemCriado = false;
            return Index(service.UpdateOne(tanqueEditado));
        }
        [HttpPost]
        public IActionResult UpdateAnfibio(TanqueAnfibio tanqueEditado)
        {
            ViewBag.itemAtualizado = true;
            ViewBag.itemCriado = false;
            return Index(service.UpdateOne(tanqueEditado));
        }

        [HttpGet]
        public IActionResult CriarLeve()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CriarLeve(TanqueLeve tanque)
        {
            ViewBag.itemAtualizado = false;
            ViewBag.itemCriado = true;
            return Index(service.Create(tanque));
        }
        [HttpGet]
        public IActionResult CriarMedio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CriarMedio(TanqueMedio tanque)
        {
            ViewBag.itemAtualizado = false;
            ViewBag.itemCriado = true;
            return Index(service.Create(tanque));
        }
        [HttpGet]
        public IActionResult CriarPesado()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CriarPesado(TanquePesado tanque)
        {
            ViewBag.itemAtualizado = false;
            ViewBag.itemCriado = true;
            return Index(service.Create(tanque));
        }
        [HttpGet]
        public IActionResult CriarCaca()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CriarCaca(CacaTanque tanque)
        {
            ViewBag.itemAtualizado = false;
            ViewBag.itemCriado = true;
            return Index(service.Create(tanque));
        }
        [HttpGet]
        public IActionResult CriarAnfibio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CriarAnfibio(TanqueAnfibio tanque)
        {
            ViewBag.itemAtualizado = false;
            ViewBag.itemCriado = true;
            return Index(service.Create(tanque));
        }
    }
}
