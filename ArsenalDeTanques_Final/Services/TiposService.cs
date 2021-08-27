using ArsenalDeTanques.Data;
using ArsenalDeTanques.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalDeTanques.Services
{
    public class TiposService
    {
        ArsenalContext context;
        public TiposService(ArsenalContext context)
        {
            this.context = context;
        }
        public List<TipoTanque> GetAll()
        {
            List<TipoTanque> tipos = context.TipoTanque.AsNoTracking().ToList();
            return tipos;
        }
    }
}
