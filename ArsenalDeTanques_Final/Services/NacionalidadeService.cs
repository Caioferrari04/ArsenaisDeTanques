using ArsenalDeTanques.Data;
using ArsenalDeTanques.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ArsenalDeTanques.Services
{
    public class NacionalidadeService
    {
        ArsenalContext context;
        public NacionalidadeService(ArsenalContext context)
        {
            this.context = context;
        }
        public bool Create(Nacionalidade nacionalidade)
        {
            try
            {
                context.Nacionalidade.Add(nacionalidade);
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
                context.Nacionalidade.Remove(Get(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Nacionalidade Get(int id)
        {
            Nacionalidade nacionalidade = context.Nacionalidade.Include(t => t.tanques).FirstOrDefault(p => p.Id == id);
            return nacionalidade != null ? nacionalidade : null;
        }

        public List<Nacionalidade> GetAll(string busca = null, bool ord = false)
        {
            List<Nacionalidade> nacionalidades = context.Nacionalidade.AsNoTracking().Include(t => t.tanques).ToList();
            if (ord == true)
            {
                var lista = nacionalidades;
                //lista.Sort((pa,pb) => pa.Nome.CompareTo(pb.Nome));
                lista = lista.OrderBy(p => p.Nome).ToList();
                return lista;
            }
            return busca != null ? nacionalidades.FindAll(a => a.Nome.ToLower().Contains(busca.ToLower())) : nacionalidades;
        }

        public bool Update(Nacionalidade nacionalidade)
        {
            try
            {
                context.Nacionalidade.Update(nacionalidade);
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

