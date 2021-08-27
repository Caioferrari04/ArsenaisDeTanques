using ArsenalDeTanques.Models;
using ArsenalDeTanques.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace ArsenalDeTanques.Controllers
{
    public class TanquesController : Controller
    {
        ICrudService service;
        NacionalidadeService nacionalidadesService;
        TanqueAdditionalService serviceMisc;
        TanquesStaticService serviceStatic;
        HybridServices hybridServices;
        TiposService typeService;
        ComprasService buyService;
        public TanquesController(ICrudService sqlService, TanqueAdditionalService serviceMisc, NacionalidadeService nacionalidadesService, TanquesStaticService serviceStatic, HybridServices hybridServices,TiposService typeService, ComprasService buyService)
        {
            this.serviceMisc = serviceMisc;
            this.nacionalidadesService = nacionalidadesService;
            this.serviceStatic = serviceStatic;
            this.hybridServices = hybridServices;
            this.typeService = typeService;
            this.buyService = buyService;
            service = sqlService;
        }
        public void GetService(string busca = null,string servico = "sql")
        {
            if (servico.Contains("sql"))
            {
                ViewBag.servico = "sql";
            } 
            else if(servico.Contains("static"))
            {
                ViewBag.servico = "static";
                this.service = this.serviceStatic;
            } 
            else
            {
                ViewBag.servico = "hibrido";
                this.service = this.hybridServices;
            }
            var tanques = service.GetAll(busca);
            ViewBag.totalTripulacao = serviceMisc.totalTripulacao(tanques);
            ViewBag.tanqueRecente = serviceMisc.tanqueRecente(tanques);
            ViewBag.maiorMotor = serviceMisc.maiorMotor(tanques);
            ViewBag.maisCaro = serviceMisc.maisCaro(tanques);
            ViewBag.tipos = typeService.GetAll();
            ViewBag.nacoes = nacionalidadesService.GetAll();
            ViewBag.comprado = buyService.GetAll(User.Identity.Name); 
            if (servico.Contains("ord") && !servico.Contains("no")) ViewBag.ordenar = true; else ViewBag.ordenar = false;
        }
        public IActionResult Index(string busca, string servico = "sql")
        {
            ViewBag.operacaoRealizada = "";
            GetService(busca, servico);
            return View(service.GetAll(busca, servico));
        }

        [Authorize]
        [HttpGet]
        public IActionResult Criar(string servico = "sql")
        {
            var nacionalidades = nacionalidadesService.GetAll();
            ViewBag.Tanques = new SelectList(nacionalidades, "Id", "Nome");
            var tipos = typeService.GetAll();
            ViewBag.tipos = new SelectList(tipos, "id", "NomeTipo");
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Tanque tanqueCriado)
        {
            var nacionalidades = nacionalidadesService.GetAll();
            ViewBag.Tanques = new SelectList(nacionalidades, "Id", "Nome", tanqueCriado.nacionalidade);
            var tipos = typeService.GetAll();
            ViewBag.tipos = new SelectList(tipos, "id", "NomeTipo", tanqueCriado.tipo);
            if (!ModelState.IsValid) return View(tanqueCriado);

            if (service.Create(tanqueCriado))
            {
                ViewBag.operacaoRealizada = "create";
                GetService();
                return View("Index", service.GetAll());
            }
            else throw new Exception();
        }

        [Authorize]
        public IActionResult ReadSingle(int id, string servico = "sql")
        {
            GetService(servico);
            return View(service.Get(id,true));
        }

        [Authorize]
        [HttpGet]
        public IActionResult Update(int id, string servico = "sql")
        {
            Tanque tanque = service.Get(id);
            var nacionalidades = nacionalidadesService.GetAll();
            GetService(servico);
            ViewBag.Tanques = new SelectList(nacionalidades, "Id", "Nome", tanque.nacionalidade);
            return View(tanque);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Tanque tanqueEditado)
        {
            var nacionalidades = nacionalidadesService.GetAll();
            ViewBag.Tanques = new SelectList(nacionalidades, "Id", "Nome", tanqueEditado.nacionalidade);
            if (!ModelState.IsValid) return View(tanqueEditado);
            if (service.Update(tanqueEditado))
            {
                ViewBag.operacaoRealizada = "update";
                GetService();
                return View("Index", service.GetAll());
            }
            else return View(tanqueEditado);
        }

        [Authorize]
        public IActionResult Delete(int id, string servico = "sql")
        {
            GetService(servico);
            return View(service.Get(id));
        }

        [Authorize]
        public IActionResult ConfirmarDelete(int id)
        {
            if (service.Delete(id)) { 
                GetService(); 
                ViewBag.operacaoRealizada = "delete";
                return View("Index", service.GetAll()); 
            }
            else return View(service.Get(id));
        }
    }
}
