using ArsenalDeTanques.Data;
using ArsenalDeTanques.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalDeTanques.Services
{
    public class ComprasService
    {
        ArsenalContext context;
        public ComprasService(ArsenalContext context)
        {
            this.context = context;
        }
        public bool Comprar(Tanque tanqueComprado,string userName)
        {
            try
            {
                Compra compra = new Compra();
                compra.tanque = tanqueComprado;
                compra.tanqueId = tanqueComprado.Id;
                compra.PrecoCompra = tanqueComprado.PrecoCompra;
                compra.DataCompra = DateTime.Now;
                compra.userId = context.Users.FirstOrDefault(u => u.UserName == userName).Id;
                context.Compra.Add(compra);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Compra> GetAll(string userName, string busca = null, bool ord = false)
        {
            var userId = context.Users.FirstOrDefault(u => u.UserName == userName).Id;
            List<Compra> compras = context.Compra
                .AsNoTracking()
                .Where(a => a.userId == userId)
                .Include(N => N.tanque)
                .Include(M => M.tanque.nacionalidade)
                .Include(T => T.tanque.tipo)
                .ToList();
            if (ord == true)
            {
                var lista = compras;
                lista = lista.OrderBy(p => p.tanque.Nome).ToList();
                return lista;
            }
            return busca != null ? compras.FindAll(a => a.tanque.Nome.ToLower().Contains(busca.ToLower())) : compras;
        }

        public Compra Get(int id)
        {
            Compra tanque = context.Compra
                .Include(N => N.tanque)
                .Include(M => M.tanque.nacionalidade)
                .Include(T => T.tanque.tipo)
                .FirstOrDefault(p => p.id == id);
            return tanque != null ? tanque : null;
        }

        public bool Update(Compra compra, string userName)
        {
            try
            {
                compra.userId = context.Users.FirstOrDefault(u => u.UserName == userName).Id;
                context.Compra.Update(compra);
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
                context.Compra.Remove(Get(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public double? investiu(List<Compra> comprados)
        {
            double? total = 0;
            foreach (Compra compra in comprados) total += compra.PrecoCompra;
            return total;
        }
    }
}
