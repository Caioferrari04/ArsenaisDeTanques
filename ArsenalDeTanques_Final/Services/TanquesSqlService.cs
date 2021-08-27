using ArsenalDeTanques.Data;
using ArsenalDeTanques.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ArsenalDeTanques.Services
{
    public class TanquesSqlService : ICrudService
    {
        ArsenalContext context;
        public TanquesSqlService(ArsenalContext context)
        {
            this.context = context;
        }
        public bool Create(Tanque tanque)
        {
            try
            {
                tanque.Visitas = 0;
                context.Tanque.Add(tanque);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                context.Tanque.Remove(Get(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Tanque Get(int id, bool visitou = false)
        {
            Tanque tanque = context.Tanque.Include(N => N.nacionalidade).Include(T => T.tipo).FirstOrDefault(p => p.Id == id);
            if(visitou == true)
            {
                tanque.Visitas = tanque.Visitas + 1;
                context.Tanque.Update(tanque);
                context.SaveChanges();
            }
            return tanque != null ? tanque : null;
        }

        public List<Tanque> GetDestaques(List<Tanque> tanques)
        {
            List<Tanque> tanquesDestaque = new List<Tanque>();
            var newtanques = tanques.OrderByDescending(p => p.Visitas).ToList();
            int i = 0;
            while(tanquesDestaque.Count < 5)
            {
                tanquesDestaque.Add(newtanques[i]);
                i++;
            }
            return tanquesDestaque;
        }

        public List<Tanque> GetAll(string busca = null, string ord = null)
        {
            List<Tanque> tanques = context.Tanque.AsNoTracking().Include(N => N.nacionalidade).Include(T => T.tipo).ToList();
            List<Tanque> lista = new List<Tanque>();
            /*A lógica abaixo é para ordenar por tipo, pois utiliza ord como uma string
             e seus atributos ("sql ord Tanque pesado", por exemplo) como "chaves"
            para identificar que tipo de tanque deve ser filtrada.*/

            /*Achei útil utilizar o contains nessa situação, mesmo que redundante,
            para ter mais facilidade em manipular futuras aplicações utilizando a variável servico.*/
            if (ord != null ? ord.Contains("ord") : false)
            {
                if(ord.Contains("geral")) { 
                    lista = tanques;
                    lista = lista.OrderBy(p => p.Nome).ToList();
                    return lista;
                }
                else if(ord.Contains("tipo"))
                {
                    List<TipoTanque> tipos = context.TipoTanque.AsNoTracking().ToList();
                    foreach(TipoTanque tipo in tipos)
                    {
                        if (ord.Contains(tipo.NomeTipo))
                        {
                            lista = tanques.FindAll(p => p.tipo.NomeTipo == tipo.NomeTipo);
                            lista = lista.OrderBy(p => p.Nome).ToList();
                            return lista;
                        }
                    }
                }
                else
                {
                    List<Nacionalidade> nacoes = context.Nacionalidade.AsNoTracking().ToList();
                    foreach (Nacionalidade nacao in nacoes)
                    {
                        if (ord.Contains(nacao.Nome))
                        {
                            lista = tanques.FindAll(p => p.nacionalidade.Nome == nacao.Nome);
                            lista = lista.OrderBy(p => p.Nome).ToList();
                            return lista;
                        }
                    }
                }
            }
            return busca != null ? tanques.FindAll(a => a.Nome.ToLower().Contains(busca.ToLower())) : tanques;
        }

        public bool Update(Tanque tanqueEditado)
        {
            try
            {
                context.Tanque.Update(tanqueEditado);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
