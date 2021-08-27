using ArsenalDeTanques.Models;
using System.Collections.Generic;

namespace ArsenalDeTanques.Services
{
    public interface ICrudService
    {
        bool Create(Tanque tanque);
        bool Delete(int id);
        Tanque Get(int id, bool visitou = false);
        List<Tanque> GetAll(string busca = null, string ord = null);
        List<Tanque> GetDestaques(List<Tanque> tanques);
        bool Update(Tanque tanqueEditado);
    }
}
