using ArsenalDeTanques.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalDeTanques.Services
{
    public interface ITanquesStatic 
    {
        dynamic Create(dynamic tanque);
        List<Tanque> Delete(int id);
        dynamic Get(int id);
        List<Tanque> GetAll(string busca = null, bool ord = false);
        dynamic UpdateOne(dynamic tanque);
        //List<Tanque> UpdateOne(TanqueMedio tanque);
        //List<Tanque> UpdateOne(TanquePesado tanque);
        //List<Tanque> UpdateOne(CacaTanque tanque);
        //List<Tanque> UpdateOne(TanqueAnfibio tanque);
    }
}
