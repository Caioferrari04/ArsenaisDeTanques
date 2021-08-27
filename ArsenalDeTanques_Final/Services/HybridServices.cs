using ArsenalDeTanques.Data;
using ArsenalDeTanques.Models;
using System.Collections.Generic;
using System.Linq;

namespace ArsenalDeTanques.Services
{

    public class HybridServices : ICrudService
    {
        ICrudService serviceSql;
        TanquesStaticService staticService;
        ArsenalContext context;
        public HybridServices(ICrudService serviceSql, TanquesStaticService staticService,ArsenalContext context)
        {
            this.serviceSql = serviceSql;
            this.staticService = staticService;
            this.context = context;
        }

        public bool Create(Tanque tanque)
        {
            try { 
                serviceSql.Create(tanque);
                staticService.Create(tanque);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public bool Delete(int id)
        {
            Tanque tanque = serviceSql.GetAll().FirstOrDefault(p => p.Id == id);
            if (tanque != null) { 
                serviceSql.Delete(id);
                return true;
            }
            tanque = staticService.GetAll().FirstOrDefault(p => p.Id == id);
            if (tanque != null) { 
                staticService.Delete(id);
                return true;
            }
            return false;

        }

        public Tanque Get(int id, bool visitou = false)
        {
            Tanque tanque = serviceSql.GetAll().FirstOrDefault(p => p.Id == id);
            if (tanque == null) tanque = staticService.GetAll().FirstOrDefault(p => p.Id == id); 
            if (visitou) tanque.Visitas += 1;
            return tanque != null ? tanque : null;
        }

        public List<Tanque> GetAll(string busca = null, string ord = null)
        {
            List<Tanque> tanques = serviceSql.GetAll();
            List<Tanque> tanquesStatic = staticService.GetAll();
            for (int i = 0; i < tanquesStatic.Count; i++)
            {
                tanques.Add(tanquesStatic[i]);
            }
            if (ord != null ? ord.Contains("ord") : false) //Achei útil utilizar o contains nessa situação, mesmo que redundante, 
            {                                               //para ter mais facilidade em manipular
                var lista = tanques;                        //futuras aplicações utilizando a variável servico.
                lista = lista.OrderBy(p => p.Nome).ToList();
                return lista;                                          
            }
            return busca != null ? tanques.FindAll(a => a.Nome.ToLower().Contains(busca.ToLower())) : tanques;
        }

        public List<Tanque> GetDestaques(List<Tanque> tanques)
        {
            List<Tanque> tanquesDestaque = new List<Tanque>();
            var newtanques = tanques.OrderByDescending(p => p.Visitas).ToList();
            int i = 0;
            while (tanquesDestaque.Count < 5)
            {
                tanquesDestaque.Add(newtanques[i]);
                i++;
            }
            return tanquesDestaque;
        }

        public bool Update(Tanque tanqueEditado)
        {
            Tanque tanque = serviceSql.GetAll().FirstOrDefault(p => p.Id == tanqueEditado.Id);
            if (tanque != null) { 
                serviceSql.Update(tanqueEditado);
                return true;
            }
            tanque = staticService.GetAll().FirstOrDefault(p => p.Id == tanqueEditado.Id);
            if (tanque != null) {
                staticService.Update(tanqueEditado);
                return true;
            }
            return false;
        }
    }
}
